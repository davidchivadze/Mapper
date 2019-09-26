using Models.EntityModels.ExcelLoan;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Interfaces.ExcelLoan
{
    public interface IVariableTypeRepository:IBaseRepository<VariableType>
    {
        List<VariableType> GetVariableTypes();
    }
}
