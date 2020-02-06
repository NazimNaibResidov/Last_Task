using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace Task_Test.WebUI.Core.Extension
{
    public static class NodeModulesExtension
    {
        public static void NodeModules(this IApplicationBuilder app, IHostingEnvironment env)
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
    }
}
