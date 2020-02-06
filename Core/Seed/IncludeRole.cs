using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Test.WebUI.Core.seeded
{
    public class IncludeRole
    {
        public static void SeedRoles
(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync
        ("Admin").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";

                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }



        }

    }
}
