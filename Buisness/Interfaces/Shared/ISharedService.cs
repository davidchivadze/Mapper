using Models.ViewModels.Shared;
using System.Collections.Generic;

namespace Buisness.Interfaces.Shared
{
   public interface ISharedService
    {
        List<Gender> GetGenderList();
    }
}
