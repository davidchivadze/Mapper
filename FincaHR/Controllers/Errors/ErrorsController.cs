using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FincaHR.Models;
using Microsoft.AspNetCore.Mvc;

namespace FincaHR.Controllers.Errors
{
    public class ErrorsController : Controller
    {
        public IActionResult Index(string ErrorMessage)
        {

            return View(new ErrorViewModel() {ErrorText=ErrorMessage});
        }
    }
}