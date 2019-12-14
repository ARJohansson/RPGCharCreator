using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RPGCharacterCreator.Repos;
using RPGCharacterCreator.Models;
using Microsoft.EntityFrameworkCore;

namespace RPGCharacterCreator
{
    public class Startup
    {
        private IHostingEnvironment environment;
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            environment = env;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //Dependency Injection
            services.AddTransient<IUserRepo, UserRepo>();
            services.AddTransient<ICharacterRepo, CharacterRepo>();

            if (environment.IsDevelopment())
            {
                services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
                    Configuration["ConnectionStrings:RPGConnString"]));
            }
            else if (environment.IsProduction())
            {
                services.AddDbContext<AppDbContext>(options => options.UseMySql(
                    Configuration["ConnectionStrings:RPGMySqlConnString"]));
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, AppDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStatusCodePages();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            context.Database.Migrate();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });


            SeedData.Seed(context);
        }
    }
}
