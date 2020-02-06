using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task.WebUI.Data;

namespace Task_Test.WebUI.Core.Extension
{
    public static class ServiceExtension
    {
        public static void IdentityAdd(this IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>(options => {


                Tool.Options(options);

            })
              .AddEntityFrameworkStores<ApplicationIdentityDbContext>

              ().AddDefaultTokenProviders();
        }
    }
}
