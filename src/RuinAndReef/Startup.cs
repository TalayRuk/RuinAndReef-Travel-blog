using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using RuinAndReefWithMigrations.Models;

namespace RuinAndReefWithMigrations
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; set; }
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //1 add the MVC service to the project.
            //The ConfigureServices method is where we configure famework services to our application
            //removed services.AddMvc();
            //add connection to SqlServer 
            services.AddEntityFramework()
                .AddDbContext<RuinAndReefDbContext>(options =>
                    options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        { //removed  b/c we already have it above 
          //2 - UseMvc(...) - telling our app that it'll be using the MVC framework
          //Then the Configure method is where we tell ASP.NET what frameworks we want to use in our app

            //remove  app.UseMvc(routes =>
            //{
            // routes.MapRoute(
            // name: "default",
            // template: "{controller=Home}/{action=Index}/{id?}");
            //this also set up default routing which tells the project to use the index action of the Home Controller as the default route,
            // and if we have any parameters will be passed as id 
            //Next we'll create Controllers/HomeController.cs
           //});

            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Welcome to Ruin & Reef");
            });
        }
    }
}

//next go to appsettings.json and name our database and connect to db 
