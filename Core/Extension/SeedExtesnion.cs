using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Test.WebUI.Core.seeded;

namespace Task_Test.WebUI.Core.Extension
{
    public static class SeedExtesnion
    {
        public static void Seed(this IApplicationBuilder app)
        {
            
            var userMager = Tools.UserManager(app);
            RoleManager<IdentityRole> roleManager = Tools.RoleManger(app);

            IncludeRole.SeedRoles(roleManager);
            IncludeUser.SeedUsers(userMager);
        }
    }
}
