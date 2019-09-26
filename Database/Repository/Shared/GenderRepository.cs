using Database.Interfaces;
using Database.Interfaces.Shared;
using Models.EntityModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Repository.Shared
{
    public class GenderRepository:BaseRepository<Gender>,IGenderRepository
    {


        public IEnumerable<Gender> GetGenders()
        {
            return Database.Genders.AsEnumerable<Gender>();
        }
    }
}
