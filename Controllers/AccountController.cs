using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Test_Task.WebUI.Data;
using Test_Task.WebUI.Models;

namespace Test_Task.WebUI.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> singInManager;
        private readonly ILogger logger;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> singInManager,ILogger<AccountController> logger)
        {
            this.userManager = userManager;
            this.singInManager = singInManager;
            this.logger = logger;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl)
        {
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            ViewBag.returnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
       
        public async Task<IActionResult> Login(LoginModel loginModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(loginModel.Email);
                if (user.IsActive!=true)
                {
                   if (user!=null)
                {
                    await singInManager.SignOutAsync();
                   var  result = await singInManager.PasswordSignInAsync(user, loginModel.Password,false,false);
                  
                    if (result.Succeeded)
                    {
                        return Redirect(returnUrl ?? "/");
                    }
                    if (result.IsLockedOut)
                    {
                        logger.LogWarning("User account locked out.");
                        return RedirectToAction(returnUrl ?? "/");
                    }
                    else
                    {
                       
                    }
                }
                }
                else
                {
ModelState.AddModelError(",", "you account blocking ");
                }
                
                
            }
            return View(loginModel);
        }
        
      
        public async Task<IActionResult> Singout()
        {
           await singInManager.SignOutAsync();
           return RedirectToAction("Index","Home");

        }
    }
}