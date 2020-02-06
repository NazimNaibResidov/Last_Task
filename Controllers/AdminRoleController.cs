using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Test_Task.WebUI.Data;
using Test_Task.WebUI.Models;

namespace Test_Task.WebUI.Controllers
{
    [Authorize]
    public class AdminRoleController : Controller
    {
        private RoleManager<IdentityRole> roleManager;
        private UserManager<ApplicationUser> userManager;
        public AdminRoleController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }
        [Authorize(Roles ="Admin")]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string id)
        {
            var role=  await roleManager.FindByIdAsync(id);
            var member = new List<ApplicationUser>();
            var nonmember = new List<ApplicationUser>();
            foreach (var item in userManager.Users)
            {
                var list = await userManager.IsInRoleAsync(item, role.Name)?member:nonmember;
                list.Add(item);
            }
            var model = new RoleDetalis()
            {
                Role = role,
                Memebers = member,
                NonMemebers = nonmember
            };
            return View(model);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(RoleEditModel model)
        {
            IdentityResult result=default;
            if (ModelState.IsValid)
            {
                foreach (var item in model.IdsToAdd??new string[] { })
                {
                    var user = await userManager.FindByIdAsync(item);
                    if (user!=null)
                    {
                      result=  await userManager.AddToRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var items in result.Errors)
                            {
                                ModelState.AddModelError(",", items.Description);
                            }
                        }
                    }
                }
                foreach (var item in model.IdsToDelete ?? new string[] { })
                {
                    var user = await userManager.FindByIdAsync(item);
                    if (user != null)
                    {
                        result = await userManager.RemoveFromRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var items in result.Errors)
                            {
                                ModelState.AddModelError(",", items.Description);
                            }
                        }
                    }
                }
               
            }
            if (ModelState.IsValid)
            {
              return  RedirectToAction("Index","Role");
                }
            else
            {
                return View(model.RoleId);
            }
        }
    }
}