using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace NugetServer
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var rootPath = Path.Combine(env.WebRootPath, "packages");
            var physicalFileProvider = new PhysicalFileProvider(rootPath);

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = physicalFileProvider,
                RequestPath = "/packages"
            });

            app.UseDirectoryBrowser(new DirectoryBrowserOptions
            {
                FileProvider = physicalFileProvider,
                RequestPath = "/packages"
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(rootPath);
            });
        }
    }
}