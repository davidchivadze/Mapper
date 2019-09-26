using Models.EntityModels.ExcelLoan;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Interfaces.ExcelLoan
{
    public interface IReadFilesRepository : IBaseRepository<ReadFiles>
    {
        List<ReadFiles> GetReadFiles();
        ReadFiles InsertReadFile(ReadFiles file);
        bool UpdateStatus(int fileID, int statusID);
    }
}
