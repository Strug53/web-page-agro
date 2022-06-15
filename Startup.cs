using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agrokorm.Models;
using Microsoft.EntityFrameworkCore;
using agrokorm.Models.Db;
using Microsoft.EntityFrameworkCore.SqlServer;
using agrokorm.Repository;
using agrokorm.Repository.Interfaces;
using agrokorm.Models.Products;
using agrokorm.Service.ProductServices.MembraneService;
using agrokorm.Service.Interfaces;
using agrokorm.Service.Implementation.SeedService;
using agrokorm.Models.Form;

namespace agrokorm
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
            services.AddControllersWithViews();

            string ConnectionString = Configuration.GetConnectionString("AgroConnetction");
            services.AddDbContext<ProductContext>(options => options.UseSqlServer(ConnectionString));


            services.AddScoped<IMembraneRepository, MembraneRepository>();
            services.AddScoped<ISeedRepository, SeedRepository>();
            services.AddScoped<IGlobalRepository, GlobalRepository>();

            services.AddScoped<IFormClass, PriceChangingFormModel>();


            services.AddScoped<IMembraneService, MembraneService>();
            services.AddScoped<ISeedService,SeedService>();



            
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

                app.UseRouting();

                app.UseAuthorization();

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}");
                });
            }
        
    } 
}
