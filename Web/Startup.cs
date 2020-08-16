using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Web.Settings;
using Web.Installers;

namespace Web
{
	public class Startup
	{
		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration) => Configuration = configuration;

		public void ConfigureServices(IServiceCollection services)
		{
			services.InstallServicesAssembly(Configuration);
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
                app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseHsts();
			}

            app.UseHttpsRedirection();
            app.UseStaticFiles();
			app.UseRouting();

			// Swagger configuration
			var swaggerSettings = new SwaggerSettings();
			Configuration.GetSection(nameof(SwaggerSettings)).Bind(swaggerSettings);

            app.UseSwagger(option =>
            {
                option.RouteTemplate = swaggerSettings.JsonRoute;
            });

			app.UseSwaggerUI(option =>
			{
				option.SwaggerEndpoint(swaggerSettings.UiEndpoint, swaggerSettings.Description);
			});

			// Common configuration
			app.UseDefaultFiles();

			// Auth configuration
			app.UseCors(x => x
                 .AllowAnyOrigin()
                 .AllowAnyMethod()
                 .AllowAnyHeader());

            // Auth configuration
            app.UseAuthentication();
			app.UseAuthorization();

			// Endpoint configuration
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
