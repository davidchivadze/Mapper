using Database.Interfaces.ExcelLoan;
using Models.EntityModels.ExcelLoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Repository.ExcelLoan
{
    public class UploadFileTypeRepository : BaseRepository<UploadFileType>, IUploadFileTypeRepository
    {
        public List<UploadFileType> GetFileTypeList()
        {
            return Database.UploadFileTypeEntities.ToList();
        }

       
    }
}
