
using Models.ViewModels.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Interfaces.Auth
{
    public interface IUserService 
    {
        bool AddUser(UserViewModel model);
        List<string> LoginUser(UserLoginViewModel model);
        List<UserViewModel> GetUsersList();
        UserViewModel GetUserByID(int userID);
        UserViewModel UpdateUser(UserViewModel model);

    }
}
