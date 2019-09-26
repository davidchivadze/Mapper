using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FincaHR.Controllers
{
    public class SharedController : BaseController
    {
        public IActionResult GetGenderList()
        {
            return View();
        }
    }
}