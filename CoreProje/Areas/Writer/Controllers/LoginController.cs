﻿using CoreProje.Areas.Writer.Models;
using EntityLayer.conrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProje.Areas.Writer.Controllers
{
    [AllowAnonymous] // bütün kurallardan muaf 
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class LoginController : Controller
    {
        private readonly SignInManager<WriterUser> _signInManager;

        public LoginController(SignInManager<WriterUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.Username, p.Password, true,true);//loginin kontrolunu sağlar 

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile",new {area="Writer"});//  ilk değere gidiyor olabilir o yuzden area(writer) yolu verdik 
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı Kullanıcı adı veya şifre");
                }
             
            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Login");
        }
    }
}
