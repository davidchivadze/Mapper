using Database.Interfaces.ExcelLoan;
using Models.EntityModels.ExcelLoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Repository.ExcelLoan
{
    public class UnplanedExcelDataRepository : BaseRepository<UnplanedExcelData>, IUnplanedExcelDataRepository
    {
        public bool AddUnplanedExcelDataList(List<UnplanedExcelData> data)
        {
            try
            {
                foreach (var variable in data)
                {
                    Database.UnplanedExcelDatas.Add(variable);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " \n" + ex.InnerException);
            }

        }
        public bool AddUnplanedExcelData(UnplanedExcelData data)
        {
            try
            {
                Database.UnplanedExcelDatas.Add(data);
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message + "\n" + ex.InnerException);
            }
        }
        public bool UpdateUnplanedExcelData(UnplanedExcelData data)
        {
            var dbData = Database.UnplanedExcelDatas.Where(m => m.ID == data.ID).FirstOrDefault();
            dbData.ReadFileID = data.ReadFileID;
            dbData.ValueDecimal = data.ValueDecimal;
            dbData.ValueInt = data.ValueInt;
            dbData.ValueNvarchar = data.ValueNvarchar;
            dbData.VariableName = data.VariableName;
            Database.UnplanedExcelDatas.Update(dbData);
            Database.SaveChanges();
            return true;
        }
        public bool DeleteUnplanedExcelData(UnplanedExcelData data)
        {
            try { 
            var deleteData = Database.UnplanedExcelDatas.Where(m => m.ID == data.ID).FirstOrDefault();
            deleteData.IsDeleted = true;
            Database.SaveChanges();
            return true;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
