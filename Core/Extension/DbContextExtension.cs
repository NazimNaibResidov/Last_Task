using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task.WebUI.Data;

namespace Task_Test.WebUI.Core.Extension
{
    public static class DbContextExtension
    {
        public static void DbContextAdd(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<ApplicationIdentityDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("Main")));
        }
    }
}
