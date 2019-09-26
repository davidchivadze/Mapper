using System;
using System.Collections.Generic;
using System.Text;
using Models.ViewModels;
using Models.EntityModels.Auth;
using Models.ViewModels.Auth;

namespace Core.Mappers.Auth
{
    public static class Transformer
    {
        public static UserViewModel AsViewModel(User model)
        {
            return new UserViewModel()
            {
                ID = model.ID,
                FirstName = model.FirstName,
                LastName = model.LastName,
                BirthDate = model.BirthDate,
                PIN = model.PIN,
                Address = model.Address,
                IsDeleted = model.IsDeleted,

            };
        }
        public static User AsDatabaseModel(UserViewModel model)
        {
            return new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                BirthDate = model.BirthDate,
                PIN = model.PIN,
                Address = model.Address,
                UserName = model.UserName,
                IsDeleted = model.IsDeleted,
                Password = model.Password,


            };
        }
    }
}
