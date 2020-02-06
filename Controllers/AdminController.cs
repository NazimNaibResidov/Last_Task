using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Test_Task.WebUI.Data;
using Test_Task.WebUI.Models;

namespace Test_Task.WebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private IPasswordHasher<ApplicationUser> passwordHasher;
        private IPasswordValidator<ApplicationUser> passwordValidator;

        public AdminController(UserManager<ApplicationUser> _userManager, IPasswordHasher<ApplicationUser> _passwordHasher, IPasswordValidator<ApplicationUser> _passwordValidator)
        {
            this.userManager = _userManager;
            this.passwordHasher = _passwordHasher;
            this.passwordValidator = _passwordValidator;
        }
        [Authorize(Roles="Admin")]
        public IActionResult Index()
        {
            return View(userManager.Users);
        }
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }
       
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel register)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser();
                user.PhoneNumberConfirmed = true;
                user.EmailConfirmed = true;
                user.UserName = register.Name;
                user.Email = register.Email;
               

                
                var result = await userManager.CreateAsync(user, register.Password);
               
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError(",", item.Description);
                    }
                }
            }
            return View(register);
        }
         public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string id)
        {
            var user =await userManager.FindByIdAsync(id);
            if (user!=null)
            {
              var result= await userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError(",", item.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError(",", "User Not Found ");
            }
            
            return View(userManager.Users);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(string id)
        {
            var user =await userManager.FindByIdAsync(id);
            if (user!=null)
            {
                return View(user);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(string id,string UserName, string Email,string Password)
        {
            var user =await userManager.FindByIdAsync(id);
            if (user!=null)
            {
                user.UserName = UserName;
                user.Email = Email;
                IdentityResult valPass = null;
                if (!string.IsNullOrEmpty(Password))
                {
                    valPass = await passwordValidator.ValidateAsync(userManager, user, Password);
                    if (valPass.Succeeded)
                    {
                        user.PasswordHash = passwordHasher.HashPassword(user, Password);
                    }
                    else
                    {
                        foreach (var item in valPass.Errors)
                        {
                            ModelState.AddModelError(",", item.Description);
                        }
                    }
                }
                if (valPass.Succeeded)
                {
                    var result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError(",", item.Description);
                        }
                    }
                }
            }
            else
            {
                ModelState.AddModelError(",", "User Not Found");
            }
            return View(user);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Block(string id)
        {
          
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByIdAsync(id);
                user.IsActive = true;
                var reult=  await userManager.UpdateAsync(user);
                if (reult.Succeeded)
                {
                   
                    return RedirectToAction("Index");
                   
                }
                else
                {
                    foreach (var item in reult.Errors)
                    {
                        ModelState.AddModelError(",", item.Description);
                    }
                }
            }
          
            return View();
        }
    }
}