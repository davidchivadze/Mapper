using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FincaHR.Controllers
{
    [Authorize(Roles="HR")]
    public class HRController : Controller
    {
        public IActionResult Employee()
        {
            return View();
        }
    }
}