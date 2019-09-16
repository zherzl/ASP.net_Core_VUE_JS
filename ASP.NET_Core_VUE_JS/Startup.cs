using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Model.Repositories;
using Core.Repository.EF;
using Core.Repository.EF.Repositories;
using Gallery.Services.Implementations;
using Gallery.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gallery
{
  public class Startup
  {
    public const string MySpecificOrigin = "_myAllowSpecificOrigins";

    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.Configure<CookiePolicyOptions>(options =>
      {
        // This lambda determines whether user consent for non-essential cookies is needed for a given request.
        options.CheckConsentNeeded = context => true;
        options.MinimumSameSitePolicy = SameSiteMode.None;
      });

      DIConfiguration(services);

      services.AddCors(options =>
      {
        options.AddPolicy(MySpecificOrigin,
          builder =>
          {
            builder.WithOrigins("*")
            .AllowAnyHeader()
            .AllowAnyMethod();
          });
      });

      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

      app.UseCors(MySpecificOrigin);
      app.UseHttpsRedirection();
      app.UseStaticFiles();
      app.UseCookiePolicy();

      app.UseMvc(routes =>
      {
        //routes.MapRoute(
        //          name: "default",
        //          template: "{controller=Home}/{action=Index}/{id?}");

        routes.MapRoute(
                  name: "Home controller",
                  template: "{controller}/{*.}",
                  defaults: new { controller = "Vue", action = "Index" },
                  constraints: new { controller = "examplevuerouter|ExampleSeedingRazor" }
                  //template: "{controller}/{action=Index}/{id?}"
                  );
      });
      //Data Source=SHARPPC;Initial Catalog=BankAccount;Persist Security Info=True;User ID=sa

      
      //routes.MapRoute(
      //  name: "Silo Controller",
      //  url: "{controller}/{*.}",
      //  defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
      //  constraints: new { controller = "examplevuerouter|ExampleSeedingRazor" }
      //  );
    }


    private void DIConfiguration(IServiceCollection services)
    {
      GalleryContext.Configuration = Configuration;
      services.AddDbContext<GalleryContext>(options => options.UseSqlServer(Configuration.GetConnectionString("GalleryContext")));

      // Repositories
      services.AddScoped<ICarsRepository, CarsRepository>();
      services.AddScoped<IAppUserRepository, AppUserRepository>();
      

      // Services
      services.AddScoped<ICarService, CarService>();
    }


  }
}
