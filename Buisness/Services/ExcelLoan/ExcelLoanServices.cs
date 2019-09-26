using Buisness.Interfaces.ExcelLoan;
using Core.Mappers.ExcelLoan;
using Models.Shared;
using Models.ViewModels.ExcelLoan;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.CSharp;
using OfficeOpenXml;
using System.Reflection;
using Models.EntityModels.ExcelLoan;

namespace Buisness.Services.ExcelLoan
{
    public class ExcelLoanServices : BaseService, IExcelLoanServices
    {
        public IEnumerable<UploadFileViewModel> GetFileList()
        {
            var data = UploadFileRepository.GetUploadFileList().Where(m => m.IsActive == true).ToList();

            return data.Select(m => Transformer.AsDatabaseModel(m));

        }

        public IEnumerable<UploadFileTypeViewModel> GetUploadFileTypes()
        {
            return UploadFileTypeRepository.GetFileTypeList().Select(m => new UploadFileTypeViewModel() { ID = m.ID, Description = m.Description, FilesPath = m.FilesPath }).ToList();
        }
        public bool SaveExcelFileToDatabase(UploadFileViewModel model)
        {
            try
            {
                using (var ms = new MemoryStream())
                {
                    model.UploadFile.CopyTo(ms);
                    model.FileBytes = ms.ToArray();
                }
                model.UploadDate = DateTime.Now;
                model.IsActive = true;
                model.IsImported = false;
                if (UploadFileRepository.DisableActiveFileStatuses(model.FileTypeID) && UploadFileRepository.SaveExcelFileToDatabase(Transformer.AsDatabaseModel(model)))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public List<FileListModel> GetFileListByTypes(string rootDirectory)
        {
            List<FileListModel> returnList = new List<FileListModel>();
            //List<string> filesList = new List<string>();
            try
            {
                var fileTypes = this.GetUploadFileTypes();
                string pathToFolder;
                foreach (var fileType in fileTypes)
                {
                    pathToFolder = rootDirectory + fileType.FilesPath;
                    foreach (string file in Directory.EnumerateFiles(pathToFolder, "*", SearchOption.AllDirectories))
                    {
                        returnList.Add(new FileListModel() { FileName = file, FileTypeID = fileType.ID, FileTypeName = fileType.Description });
                    }

                }


                return returnList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<object> ReadExcelFileData(List<FileListModel> filesList, string rootPath, Type objectType)
        {

            var MappingData = FileMappingRepository.GetFileMappingsData();
            List<object> returnlist = new List<object>();
            foreach (var path in filesList)
            {
                object mappingObject = Activator.CreateInstance(objectType);
                FileInfo file = new FileInfo(path.FileName);
                using (ExcelPackage package = new ExcelPackage(file))
                {


                    foreach (var sheetName in MappingData.Where(m => m.FileTypeID == path.FileTypeID).Select(m => m.SheetName).Distinct())
                    {
                        string currentSheet = sheetName;
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[currentSheet];
                        foreach (var cellCode in MappingData.Where(m => m.FileTypeID == path.FileTypeID && m.SheetName == currentSheet))
                        {
                            string cellValue = null;
                            try
                            {
                                cellValue = worksheet.Cells[cellCode.Cell].Value.ToString();
                            }
                            catch
                            {
                                cellValue = null;
                            }

                            PropertyInfo property = mappingObject.GetType().GetProperty(cellCode.VariableName);
                            property.SetValue(mappingObject, Convert.ChangeType(cellValue, property.PropertyType), null);

                        }
                    }

                }
                returnlist.Add(mappingObject);
            }
            return returnlist;


        }

        public void ReadFile(List<FileListModel> filesList, string rootPath)
        {
            var MappingData = FileMappingRepository.GetFileMappingsData();
            List<object> returnlist = new List<object>();
            foreach (var path in filesList)
            {
                int fileID =
                    ReadFilesRepository.Add(new Models.EntityModels.ExcelLoan.ReadFiles()
                    {
                        FileName = path.FileName,
                        UploadFileTypeID = path.FileTypeID,
                        ReadFileStatusID = (int)ReadFileStatus.Faild
                    }).ID;


                FileInfo file = new FileInfo(path.FileName);
                using (ExcelPackage package = new ExcelPackage(file))
                {


                    foreach (var sheetName in MappingData.Where(m => m.FileTypeID == path.FileTypeID).Select(m => m.SheetName).Distinct())
                    {

                        string currentSheet = sheetName;
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[currentSheet];
                        foreach (var cellCode in MappingData.Where(m => m.FileTypeID == path.FileTypeID && m.SheetName == currentSheet))
                        {
                            string cellValue = null;
                            try
                            {
                                cellValue = worksheet.Cells[cellCode.Cell].Value.ToString();
                            }
                            catch
                            {
                                cellValue = null;
                            }
                            try
                            {
                                UnplanedExcelDataRepository.Add(new UnplanedExcelData()
                                {
                                    ReadFileID = fileID,
                                    VariableName = cellCode.VariableName,
                                    ValueNvarchar = cellValue
                                });
                            }
                            catch (Exception ex)
                            {
                                throw new Exception("Insert UnplanedExcelData Error:" + ex.Message + "\n" + ex.InnerException);
                            }

                        }
                    }

                }
                ReadFilesRepository.UpdateStatus(fileID, (int)ReadFileStatus.Success);
            }

        }


        public void ImportMapping(int fileID)
        {
            var file = UploadFileRepository.Get().Where(m => m.ID == fileID && m.IsActive == true && m.IsImported == false).FirstOrDefault();

            if (file != null)
            {
                using (MemoryStream ms = new MemoryStream(file.UploadFileData))
                {
                    using (ExcelPackage excel = new ExcelPackage(ms))
                    {
                        if (excel.Workbook.Worksheets.Count == 0)
                        {
                            throw new Exception("File Is Empty");
                        }
                        else
                        {
                            try
                            {
                                List<FileMappingViewModel> fileMapping = new List<FileMappingViewModel>();
                                var worksheet = excel.Workbook.Worksheets.FirstOrDefault();
                                var start = worksheet.Dimension.Start;
                                var end = worksheet.Dimension.End;
                                for (int row = start.Row + 1; row <= end.Row; row++)
                                {
                                    fileMapping.Add(new FileMappingViewModel()
                                    {
                                        SheetName = worksheet.Cells[row, 1].Text,
                                        VariableName = worksheet.Cells[row, 2].Text,
                                        Cell = worksheet.Cells[row, 3].Text,
                                        FileTypeID = file.UploadFileTypeID,
                                        VariableTypeID = (int)VariableTypes.Nvarchar
                                    });
                                }
                                if (fileMapping.Count == 0)
                                {
                                    throw new Exception("File Is not Correct");
                                }

                            FileMappingRepository.ImportNewMappingData(fileMapping.Select(m => Transformer.AsDatabaseModel(m)).ToList(), file.UploadFileTypeID);
                            UploadFileRepository.CheckAsImported(file.ID);
                            }
                            catch (Exception ex)
                            {
                                throw new Exception(ex.Message);
                            }
                        }
                    }
                }

            }

            else
            {
                throw new Exception("File Not Found! It's already deactivated or imported!");
            }

        }

        public UploadFileTypeViewModel AddUploadFileType(UploadFileTypeViewModel model,string rootPath)
        {

            model.FilesPath = "/Files/" + model.FilesPath;
            var path = rootPath + model.FilesPath;
            if (Directory.Exists(path))
            {
                throw new Exception("ამ სახელით დირექტორია უკვე არსებობს");
            }
            else
            {
                Directory.CreateDirectory(path);
                return Transformer.AsViewModelModel(UploadFileTypeRepository.Add(Transformer.AsDatabaseModel(model)));
            }
        }
        public void UploadProcessingFiles(UploadProcessingFilesViewModel model,string rootDirectory)
        {
            if (model.Files.Count > 0)
            {
                foreach(var file in model.Files)
                {
                    var fileTypeDirectory = UploadFileTypeRepository.GetFileTypeList().Where(m => m.ID == model.FileTypeID).FirstOrDefault();
                    string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmssffff");
                    var path = rootDirectory+fileTypeDirectory.FilesPath+"/"+timeStamp+"_"+file.FileName;

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyToAsync(stream);
                    }
                }
            }
            else
            {
                throw new Exception("No Files Chosen..");
            }
        }
    }
}
