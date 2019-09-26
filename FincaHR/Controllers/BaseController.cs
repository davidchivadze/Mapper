using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buisness.Interfaces.Auth;
using Buisness.Interfaces.ExcelLoan;
using Buisness.Interfaces.Shared;
using Buisness.Services.AdminPanel;
using Buisness.Services.ExcelLoan;
using Buisness.Services.Shared;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace FincaHR.Controllers
{
    public class BaseController : Controller
    {
        private IUserService _userService;
        protected IUserService UserService
        {
            get
            {
                return _userService = _userService ?? new UserService();
            }
        }
        private ISharedService _sharedService;
        protected ISharedService SharedService
        {
            get
            {
                return _sharedService = _sharedService ?? new SharedService();
            }
        }

        private IExcelLoanServices _ExcelLoanServices;
        protected IExcelLoanServices ExcelLoanServices
        {
            get
            {
                return _ExcelLoanServices = _ExcelLoanServices ?? new ExcelLoanServices();
            }
        }


    }
}