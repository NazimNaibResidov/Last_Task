using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Test.WebUI.Core
{
    public class Tool
    {
        public static void Node_Modules(IApplicationBuilder app, dynamic env)
        {
            app.UseFileServer(new FileServerOptions()
            {
                FileProvider = new PhysicalFileProvider(
                   Path.Combine(env.ContentRootPath, "node_modules")
               ),
                RequestPath = "/node_modules",
                EnableDirectoryBrowsing = false
            });
        }
        public static void Options(IdentityOptions options)
        {
            options.Password.RequiredLength = 5;
            options.Password.RequireLowercase = false;

            options.Password.RequireUppercase = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireDigit = false;
            options.Password.RequiredUniqueChars = 0;
            options.SignIn.RequireConfirmedEmail = true;
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            options.Lockout.MaxFailedAccessAttempts = 5;
            options.Lockout.AllowedForNewUsers = true;

        }
    }
}
