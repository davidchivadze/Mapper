using Buisness.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Models.ViewModels.Auth;
using Core.Mappers.Auth;
using Core.Shared;
using Buisness.Interfaces.Auth;

namespace Buisness.Services.AdminPanel
{
    public class UserService : BaseService, IUserService
    {
        public bool AddUser(UserViewModel model)
        {
            if (model.Password != null)
            {
                model.Password = Core.Shared.Encryption.CreateMD5(model.Password);
            }
            if (UserRepository.Add(Transformer.AsDatabaseModel(model))!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<string> LoginUser(UserLoginViewModel model)
        {
            try
            {
                var loginUser = UserRepository.GetUser(model.UserName, Encryption.CreateMD5(model.Password));

                if (loginUser == null)
                {
                    return new List<string>();
                }
                else
                {
                    var UserRoles = UserRepository.GetUserRoles(loginUser.ID);
                    var returnRolesName = new List<string>();
                    foreach (var role in UserRoles)
                    {
                        returnRolesName.Add(role.RoleName);
                    }
                    return returnRolesName;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<UserViewModel> GetUsersList()
        {
            var result = UserRepository.Get();
            return result.Select(m => new UserViewModel()
            {
                FirstName = m.FirstName,
                LastName = m.LastName,
                BirthDate = m.BirthDate,
                PIN = m.PIN,
                ID = m.ID,
                IsDeleted = m.IsDeleted,
                Address = m.Address,
                UserName = m.UserName,
                UserRoles = m.Roles.Select(n => new RolesViewModel()
                {
                    RoleName = n.Role.RoleName,
                    Description = n.Role.Description,
                    ID = n.Role.ID
                }).ToList()
            }).ToList();
        }
        public UserViewModel GetUserByID(int userID)
        {
            return Transformer.AsViewModel(UserRepository.Get().Where(m => m.ID == userID).FirstOrDefault());
        }
        public UserViewModel UpdateUser(UserViewModel model)
        {
            var user = UserRepository.Get().Where(m => m.ID == model.ID).FirstOrDefault();
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.BirthDate = model.BirthDate;
            user.Address = model.Address;

            return Transformer.AsViewModel(UserRepository.Update(user));
        }
    }
}
