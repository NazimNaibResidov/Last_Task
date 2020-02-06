using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task.WebUI.Data;

namespace Task_Test.WebUI.Core.seeded
{
    public class IncludeUser
    {
        public static void SeedUsers
(UserManager<ApplicationUser> userManager)
        {
            if (userManager.Users.Count() == 0)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = "Naib";
                user.PhoneNumberConfirmed = true;
                user.EmailConfirmed = true;
                user.Email = "residovnaib@gmail.com";
                IdentityResult result = userManager.CreateAsync
                 (user, "7505020r").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user,
                                        "Admin").Wait();
                }
            }
        }
    }
}
