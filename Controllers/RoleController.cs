using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Test_Task.WebUI.Controllers
{
    [Authorize]
    public class RoleController : Controller
    {
        private RoleManager<IdentityRole> roleManager;
        public RoleController(RoleManager<IdentityRole> _roleManager)
        {
            roleManager = _roleManager;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View(roleManager.Roles);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(string name)
        {
            if (ModelState.IsValid)
            {
                var roles =await roleManager.CreateAsync(new IdentityRole(name));
                if (roles.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var item in roles.Errors)
                    {
                        ModelState.AddModelError(",", item.Description);
                    }
                }
              
            }  return View();
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string id)
        {
            var Role =await roleManager.FindByIdAsync(id);
            if (Role!=null)
            {
                var result =await roleManager.DeleteAsync(Role);
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
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(string id)
        {
            var role =await roleManager.FindByIdAsync(id);
            if (role != null)
            {
                return View(role);

            }
            
            return RedirectToAction("Index");
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(IdentityRole role)
        {
            IdentityRole roles =await roleManager.FindByIdAsync(role.Id);
           

            
            if (ModelState.IsValid)
            {
               
                var result = await roleManager.UpdateAsync(roles);
                if (result.Succeeded)
                {
                 return   RedirectToAction("Index");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError(",", item.Description);
                    }
                }
            }
            return View(role);
        }

    }
}