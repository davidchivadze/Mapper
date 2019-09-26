
using Models.EntityModels.ExcelLoan;
using System.Collections.Generic;

namespace Database.Interfaces.ExcelLoan
{
    public interface IFileMappingRepository:IBaseRepository<FileMapping>
    {
        IEnumerable<FileMapping> GetFileMappingsData();
        bool ImportNewMappingData(List<FileMapping> fileMappings, int fileTypeID);


    }
}
