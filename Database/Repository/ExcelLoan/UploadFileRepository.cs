using Database.Interfaces.ExcelLoan;
using Microsoft.EntityFrameworkCore;
using Models.EntityModels.ExcelLoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Repository.ExcelLoan
{
    public class UploadFileRepository : BaseRepository<UploadFile>, IUploadFileRepository
    {
        public IEnumerable<UploadFile> GetUploadFileList()
        {
            return Database.UploadFileEntities.Include(m => m.UploadFileType);
        }

        public bool SaveExcelFileToDatabase(UploadFile model)
        {
            try
            {
                Database.UploadFileEntities.Add(model);
                Database.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message + "\n Inner Exception:" + ex.InnerException.ToString());
            }
        }
        public bool DisableActiveFileStatuses(int fileTypeID)
        {
            try
            {
                (from uploadFiles in Database.UploadFileEntities
                 where uploadFiles.UploadFileTypeID == fileTypeID
                 select uploadFiles).ToList().ForEach(m => m.IsActive = false);
                Database.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n" + ex.InnerException);
            }
        }

        public bool CheckAsImported(int fileID)
        {
            try
            {
                var file = Database.UploadFileEntities.Where(m => m.ID == fileID).FirstOrDefault();
                if (file != null)
                {
                    file.IsImported = true;
                    Database.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}
