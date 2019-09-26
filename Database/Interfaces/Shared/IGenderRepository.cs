using Models.EntityModels.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Interfaces.Shared
{
   public interface IGenderRepository:IBaseRepository<Gender>
    {
        IEnumerable<Gender> GetGenders();
    }
}
