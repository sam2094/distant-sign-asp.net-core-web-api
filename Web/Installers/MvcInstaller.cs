using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Models.LogicParameters.BranchLogic;
using Models.LogicParameters.OrganizationLogic;
using Models.LogicParameters.UserLogic;
using Web.Filters;

namespace Web.Installers
{
	public class MvcInstaller : IInstaller
	{
		public void InstallServices(IServiceCollection services, IConfiguration configuration)
		{
			services.AddControllers();

			// Fluent Validation
			services.AddMvc(config =>
			{
				config.Filters.Add(new ValidationFilter());
			})
				.AddFluentValidation(opt =>
				{
					opt.RegisterValidatorsFromAssemblyContaining<UserRegisterInputValidator>();
                    opt.RegisterValidatorsFromAssemblyContaining<AddOrganizationInputValidator>();
                    opt.RegisterValidatorsFromAssemblyContaining<UpdateOrganizationInputValidator>();
                    opt.RegisterValidatorsFromAssemblyContaining<AddBranchInputValidator>();
                    opt.RegisterValidatorsFromAssemblyContaining<UpdateBranchInputValidator>();
                }).AddJsonOptions(options =>
				{
					options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
					options.JsonSerializerOptions.IgnoreNullValues = true;
				}).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

			services.Configure<ApiBehaviorOptions>(options =>
			{
				options.SuppressModelStateInvalidFilter = true;
			});

			services.AddCors();

			// Swagger Gen configuration
			services.AddSwaggerGen(x =>
			{
				x.SwaggerDoc("v3", new OpenApiInfo { Title = "Remote Signature", Version = "v3" });

				x.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
				{
					Name = "Authorization",
					Type = SecuritySchemeType.ApiKey,
					Scheme = "Bearer",
					BearerFormat = "JWT",
					In = ParameterLocation.Header,
					Description = "JWT Authorization header using the Bearer scheme."
				});

				x.AddSecurityRequirement(new OpenApiSecurityRequirement()
				{
					{
						new OpenApiSecurityScheme
						   {
							  Reference = new OpenApiReference
							  {
								Type = ReferenceType.SecurityScheme,
								Id = "Bearer"
							  },
						  },
					new string[] {}
					}
				});
			});
		}
	}
}
