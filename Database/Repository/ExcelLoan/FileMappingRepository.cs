using Database.Interfaces.ExcelLoan;
using Microsoft.EntityFrameworkCore;
using Models.EntityModels.ExcelLoan;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Database.Repository.ExcelLoan
{
    public class FileMappingRepository : BaseRepository<FileMapping>, IFileMappingRepository
    {
        public IEnumerable<FileMapping> GetFileMappingsData()
        {
            return Database.FileMappings;
        }
        public bool ImportNewMappingData(List<FileMapping> fileMappings, int fileTypeID)
        {
            try
            {
                //Database.FileMappings.FromSql("DELETE FROM dbo.FileMapping WHERE FileTypeID=@fileTypeID", fileTypeID);
                var parameter = new SqlParameter("@fileTypeID", fileTypeID);
                Database.Database.ExecuteSqlCommand("DELETE FROM dbo.FileMapping WHERE FileTypeID=@fileTypeID", parameter);
                Database.SaveChanges();
                foreach(var file in fileMappings)
                {
                    Database.Add(file);
                    Database.SaveChanges();
                }
               
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n" + ex.InnerException);
            }
        }
    }
}
