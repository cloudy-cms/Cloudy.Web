using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cloudy.CMS;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Cloudy.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options => options.AddPolicy("allow-all", builder => builder.AllowAnyOrigin()));
            services.AddMvc();
            services.AddCloudy(configure => configure
                .AddAdmin()
                .WithFileBasedDocuments()
                //.WithMongoDatabaseConnectionStringNamed("cloudy")
            );
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseCloudyAdmin(configure => configure.Unprotect());
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts(); // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseCors();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(null, "/", new { controller = "Content", action = "StartPage" });
                endpoints.MapControllerRoute(null, "/help-sections/{id:contentroute}.json", new { controller = "Content", action = "HelpSection" }).RequireCors("allow-all");
            });
        }
    }
}
