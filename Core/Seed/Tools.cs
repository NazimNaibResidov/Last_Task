using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Task_Test.WebUI.Entity;
using Test_Task.WebUI.Data;

namespace Task_Test.WebUI.Core.seeded
{
    public class Tools
    {
        private IApplicationBuilder app;
        public Tools(IApplicationBuilder builder)
        {
            this.app = builder;
            ApplicationIdentityDbContext context = app.ApplicationServices.GetRequiredService<ApplicationIdentityDbContext>();
            context.Database.Migrate();
        }
        public static UserManager<ApplicationUser> UserManager(IApplicationBuilder app)
        {ApplicationIdentityDbContext context = app.ApplicationServices.GetRequiredService<ApplicationIdentityDbContext>();
            context.Database.Migrate();
            UserManager<ApplicationUser> userManager= app.ApplicationServices.GetRequiredService<UserManager<ApplicationUser>>();
            
            return userManager;
        
        }
        public static RoleManager<IdentityRole> RoleManger(IApplicationBuilder app)
        {
            RoleManager<IdentityRole> roleManager = app.ApplicationServices.GetService<RoleManager<IdentityRole>>();

            return roleManager;
        }
        public static MainDbContext MainContext(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetRequiredService<MainDbContext>();
            context.Database.Migrate();
            return   app.ApplicationServices.GetService<MainDbContext>();
        }
    }
}
