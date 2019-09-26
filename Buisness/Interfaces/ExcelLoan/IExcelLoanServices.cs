using System;
using System.Collections.Generic;
using System.Text;
using Models.Shared;
using Models.ViewModels.ExcelLoan;

namespace Buisness.Interfaces.ExcelLoan
{
   public interface IExcelLoanServices
    {
        IEnumerable<UploadFileTypeViewModel> GetUploadFileTypes();
        UploadFileTypeViewModel AddUploadFileType(UploadFileTypeViewModel model, string rootPath);
        bool SaveExcelFileToDatabase(UploadFileViewModel model);
        IEnumerable<UploadFileViewModel> GetFileList();
        List<FileListModel> GetFileListByTypes(string rootDirectory);
        List<object> ReadExcelFileData(List<FileListModel> filesList, string rootPath, Type objectType);
        void ReadFile(List<FileListModel> filesList, string rootPath);
        void UploadProcessingFiles(UploadProcessingFilesViewModel model, string rootDirectory);
        void ImportMapping(int fileID);
    }
}
