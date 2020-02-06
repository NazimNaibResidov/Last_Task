using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Test_Task.WebUI;

namespace Task_Test.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseDefaultServiceProvider(x=>x.ValidateScopes=false)
                .UseStartup<Startup>();
    }
}
