using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Test.WebUI.Entity;

namespace Task_Test.WebUI.Core.Extension
{
   
    public static class DataBaseExtension
    {
       
        public static void Load_db(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<MainDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("Tests")));
        }
    }
}
