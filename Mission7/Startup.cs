using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Mission7.Models;

namespace Mission7
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration temp)
        {
            Configuration = temp;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<AmazonBookContext>(options =>
            {
                options.UseSqlite(Configuration["ConnectionStrings:AmazonDBConnection"]);
            });

            services.AddScoped<IAmazonBookRepository, EFAmazonBookRepository>();

            services.AddRazorPages();

            services.AddDistributedMemoryCache();

            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //recieve both category and page num
                endpoints.MapControllerRoute(
                    name: "categorypage",
                    pattern: "{category}/Page{pageNum}",
                    defaults:new { Controller = "Home", action ="Index"});

                //receive just page
                                endpoints.MapControllerRoute(
                                    name: "Paging",
                                    pattern: "Page{pageNum}",
                                    defaults: new { Controller = "Home", action = "Index", pageNum = 1 });

                //recieve just category
                endpoints.MapControllerRoute("category", "{category}", new {Controller = "Home", action="Index", pageNum = 1});

                //default
                endpoints.MapDefaultControllerRoute();

                endpoints.MapRazorPages();
            });
        }
    }
}
