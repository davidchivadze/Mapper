using System;
using System.Collections.Generic;
using System.Text;
using Models.ViewModels.ExcelLoan;
using Models.EntityModels.ExcelLoan;

namespace Core.Mappers.ExcelLoan
{
    public static class Transformer
    {
        public static UploadFileTypeViewModel AsViewModelModel(UploadFileType model)
        {
            return new UploadFileTypeViewModel()
            {
                ID = model.ID,
                Description = model.Description,
                FilesPath=model.FilesPath
            };
        }
        public static UploadFileType AsDatabaseModel(UploadFileTypeViewModel model)
        {
            return new UploadFileType()
            {
                ID = model.ID,
                Description = model.Description,
                FilesPath=model.FilesPath               
            };
        }
        public static UploadFile AsDatabaseModel(UploadFileViewModel model)
        {
            return new UploadFile()
            {
                ID=model.ID,
                IsActive = model.IsActive,
                UploadDate = model.UploadDate,
                UploadFileTypeID = model.FileTypeID,
                UploadFileData = model.FileBytes,
                FileName=model.UploadFile.FileName
            };
        }
        public static UploadFileViewModel AsDatabaseModel(UploadFile model)
        {
            return new UploadFileViewModel()
            {
                ID = model.ID,
                IsActive = model.IsActive,
                UploadDate = model.UploadDate,
                FileTypeID = model.UploadFileTypeID,
                FileBytes = model.UploadFileData,
                UploadFileTypeName = model.UploadFileType.Description,
                FileName=model.FileName,
                IsImported=model.IsImported
            };
        }
        public static FileMappingViewModel AsViewModel(FileMapping model)
        {
            return new FileMappingViewModel()
            {
                ID = model.ID,
                FileTypeID = model.FileTypeID,
                Cell = model.Cell,
                VariableName = model.VariableName,
                SheetName = model.SheetName
            };
        }
        public static FileMapping AsDatabaseModel(FileMappingViewModel model)
        {
            return new FileMapping()
            {
                VariableTypeID=model.VariableTypeID,
                ID = model.ID,
                FileTypeID = model.FileTypeID,
                Cell = model.Cell,
                VariableName = model.VariableName,
                SheetName = model.SheetName
                
            };

        }
    }
}
