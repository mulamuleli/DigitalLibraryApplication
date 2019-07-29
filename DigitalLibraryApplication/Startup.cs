using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalLibraryApplication.Middleware;
using DigitalLibraryApplication.MiddlewareExtensions;
using DigitalLibraryApplication.Models;
using DigitalLibraryApplication.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DigitalLibraryApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
          /*  services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            */
            var connection = Configuration.GetConnectionString("DefaultConnection");
            if (connection == null)
            {
                connection = "testingconnection";
            }

            services.AddDbContext<DigitalLibraryContext>(options =>
                options.UseSqlServer(connection));

            services.AddTransient<IAudioBookService, AudioBookService>();
            services.AddTransient<IAudioBookServiceAsync, AudioBookServiceAsync>();

            services.AddMvc();
            //.SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
            services.AddSingleton<EmailService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {

                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseSimpleMiddleware();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                    routes.MapRoute(
                    name: "default",
                    template: "{controller=AudioBookManual}/{action=Index}/{id?}");
            });
        }
    }
}
