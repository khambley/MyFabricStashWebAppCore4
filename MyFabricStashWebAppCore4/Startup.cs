using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using MyFabricStashWebAppCore4.Models;

namespace MyFabricStashWebAppCore4
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        //This constructor was added so that it receives the configuration data loaded from the appsettings.json file
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration["Data:MyFabricStashCoreDbConnection:ConnectionString"]));
            services.AddTransient<IFabricRepository, EFFabricRepository>();
            //services.AddTransient<IFabricRepository, FakeFabricRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // This method consists of classes (known as middleware) that will inspect HTTP requests and generate responses.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();

            app.UseMvc(routes => {
                routes.MapRoute(
                name: "default",
                template: "{controller=Fabric}/{action=List}/{id?}");
            });
            SeedData.EnsurePopulated(app);

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
