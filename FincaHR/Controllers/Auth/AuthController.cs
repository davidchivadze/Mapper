using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels;
using Models.ViewModels.Auth;

namespace FincaHR.Controllers.Auth
{
    public class AuthController : BaseController
    {
        public async Task<IActionResult> Index(UserLoginViewModel model)
        {
            //UserService.AddUser(new UserViewModel()
            //{
            //    FirstName = "daviti",
            //    LastName = "chivadze",
            //    BirthDate = DateTime.Now,
            //    UserName = "dchivadze",
            //    PIN = "35001122068",
            //    Address = "dadiani 56",
            //    Password = "admin"
            //});
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                var result = UserService.LoginUser(model);
                if (result.Count > 0)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Hash,Guid.NewGuid().ToString()),
                    };
                    foreach (var role in result)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role.ToString()));
                    }

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                    var principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(principal);

                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    return View(model);
                }
                //return RedirectToAction("Index", "Home");
            }
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Auth");
        }
        public IActionResult AccessDenided()
        {
            return View();
        }
    }
}