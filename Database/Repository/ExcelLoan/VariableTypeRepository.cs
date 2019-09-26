using Database.Interfaces.ExcelLoan;
using Models.EntityModels.ExcelLoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Repository.ExcelLoan
{
    public class VariableTypeRepository : BaseRepository<VariableType>, IVariableTypeRepository
    {
        public List<VariableType> GetVariableTypes()
        {
            return Database.VariableTypes.ToList();
        }
    }
}
