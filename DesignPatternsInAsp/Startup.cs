using DesignPatternsInAsp.Configuration;
using DesignPatternsInAsp.Tools.Factory;
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

namespace DesignPatternsInAsp
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
            
            //Inyecci�n de las configuraciones de appsettings.json
            services.Configure<MyCustomConfig>(Configuration.GetSection("MyCustomConfig"));

            //Inyecci�n de dependencias, inyectamos en el contenedor las factor�as
            services.AddTransient((factory)=> { 
                return new LocalEarnFactory(Configuration.GetSection("MyCustomConfig").GetValue<decimal>("LocalPercentage"));
            });
            services.AddTransient((factory) => {
                return new ForeignEarnFactory(Configuration
                    .GetSection("MyCustomConfig").GetValue<decimal>("ForeignPercentage"),
                    Configuration
                    .GetSection("MyCustomConfig").GetValue<decimal>("Extra"));
            });
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
