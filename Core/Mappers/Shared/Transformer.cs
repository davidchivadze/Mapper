using System;
using System.Collections.Generic;
using System.Text;
using Models.EntityModels.Shared;
using Models.ViewModels.Shared;

namespace Core.Mappers.Shared
{
   public static class Transformer
    {
       public static Models.EntityModels.Shared.Gender AsViewModelObject(Models.ViewModels.Shared.Gender model)
        {
            return new Models.EntityModels.Shared.Gender
            {
                ID = model.ID,
                Description = model.Description
            };
        }
    }
}
