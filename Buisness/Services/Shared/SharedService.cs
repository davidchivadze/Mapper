using Buisness.Interfaces.Shared;
using Models.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buisness.Services.Shared
{
    public class SharedService : BaseService,ISharedService
    {
        public List<Gender> GetGenderList()
        {
           return GenderRepository.GetGenders().Select(m=>new Gender() { ID=m.ID,Description=m.Description}).ToList();
        }
    }
}
