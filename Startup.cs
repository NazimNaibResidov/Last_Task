using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Task_Test.WebUI.Core.Extension;
using Task_Test.WebUI.Entity.Abstrac;
using Task_Test.WebUI.Entity.Concreate;

namespace Test_Task.WebUI
{
    public class Startup
    {
        private IConfiguration Configuration { get; }
        public Startup(IConfiguration _Configuration)
        {
            this.Configuration = _Configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddAuthorization(options =>
            {

                options.AddPolicy("Admin",
                    authBuilder =>
                    {
                        authBuilder.RequireRole("Administrators");
                    });

            });
            services.DbContextAdd(Configuration);

            services.IdentityAdd();

            services.Load_db(Configuration);
            services.AddTransient<ICategoryRepstory, Categoryresptory>();
            services.AddTransient<ICityRepstory, CitryResptory>();
            services.AddTransient<IArrivalRepostory,ArrivalResptory>();
            services.AddTransient<IDepartrueRepostory, DepartrueResptory> ();

            services.AddTransient<IproductRepstory,ProductResptory>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }



            app.UseStaticFiles();
            app.UseStatusCodePages();

            app.NodeModules(env);
            app.Seed();
            app.SaveContext();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
