using Models.EntityModels.ExcelLoan;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Interfaces.ExcelLoan
{
    public interface IUnplanedExcelDataRepository:IBaseRepository<UnplanedExcelData>
    {
        bool AddUnplanedExcelDataList(List<UnplanedExcelData> data);
        bool AddUnplanedExcelData(UnplanedExcelData data);
    }
}
