using EmployeeManagement.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Models.Extensions;
using EmployeeManagement.Events;
using EmployeeManagement.Mediator;
using MediatR;
using System.Reflection;
using System;

namespace EmployeeManagement {
  public class Startup {
		private readonly IConfiguration _config;

		public Startup(IConfiguration config) {
        _config = config;     
    }

    public void ConfigureServices(IServiceCollection services) {
			services.AddDbContextPool<AppDbContext>(options =>
				options.UseNpgsql(_config.GetConnectionString("EmployeeDBConnection"))
			);

			services.AddMvc();
			services.AddMediatR(Assembly.GetExecutingAssembly());

			services.AddScoped<IDog, Chihuahua>();
			services.AddScoped<IEmployeeRepository, PGEmployeeRepository>();
			services.AddScoped<IMediatorService, MediatorService>();
			services.AddScoped<IEmployeeRepository, PGEmployeeRepository>();

			// services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
		}

    public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error/{0}");
				app.UseStatusCodePagesWithReExecute("/Error/{0}");
			}

			app.UseMvc(routes => {
				routes.MapRoute("default", "api/{controller=Home}/{method=Index}/{id?}");
			});

			//app.Run(async (context) => {
			//	new Doodle().Roaring();
			//	await context.Response.WriteAsync(_config["MyKey"]);
			//	// await context.Response.WriteAsync(System.Diagnostics.Process.GetCurrentProcess().ProcessName);
			//});
		}

  }
}
