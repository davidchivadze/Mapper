using Models.EntityModels.ExcelLoan;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Interfaces.ExcelLoan
{
    public interface IUploadFileRepository:IBaseRepository<UploadFile>
    {
        bool SaveExcelFileToDatabase(UploadFile model);
        IEnumerable<UploadFile> GetUploadFileList();
        bool DisableActiveFileStatuses(int fileTypeID);
        bool CheckAsImported(int fileID);
    }
}
