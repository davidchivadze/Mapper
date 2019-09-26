using Database.Interfaces.ExcelLoan;
using Models.EntityModels.ExcelLoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Repository.ExcelLoan
{
    public class ReadFilesRepository : BaseRepository<ReadFiles>, IReadFilesRepository
    {
        public List<ReadFiles> GetReadFiles()
        {
            return Database.ReadFiles.ToList();
        }

        public ReadFiles InsertReadFile(ReadFiles file)
        {
            var returnFile=this.Add(file);
            return returnFile;

        }

        public bool UpdateStatus(int fileID, int statusID)
        {
            try { 
            var data = Database.ReadFiles.Where(m => m.ID == fileID).FirstOrDefault();
            data.ReadFileStatusID = statusID;
            this.Update(data);
                return true;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
