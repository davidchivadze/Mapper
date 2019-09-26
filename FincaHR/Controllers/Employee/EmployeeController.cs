using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FincaHR.Controllers.Employee
{
    public class EmployeeController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}