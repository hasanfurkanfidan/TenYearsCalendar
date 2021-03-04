﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TenYearsCalendar.Core.Dtos;
using TenYearsCalendar.Core.Entities.Concrete;

namespace TenYearsCalendar.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public AuthController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Login()
        {
            return View();
        }
        [Route("kayit-ol")]
        public IActionResult Register()
        {
            var model = new AppUserRegisterDto();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult>RegisterPost(AppUserRegisterDto appUserRegisterDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(appUserRegisterDto.Email);
                if (user==null)
                {
                   var result =  await _userManager.CreateAsync(user, appUserRegisterDto.Password);
                    if (result.Succeeded)
                    {
                        return View("Login");
                    }
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
                ModelState.AddModelError("", "Kullanıcı sistemde zaten kayıtlı!");
            }
            return View("Register", new { appUserRegisterDto });
        }
    }
}