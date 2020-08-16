using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.Services.UserServices;
using Services.Services.CertificateServices;
using Services.Services.CommonService;
using Services.Services.OrganizationServices;
using Services.Services.BranchServices;
using Services.Services.StatisticServices;

namespace Web.Installers
{
	public class ServiceInstaller : IInstaller
	{
		public void InstallServices(IServiceCollection services, IConfiguration configuration)
		{
			services.AddTransient<IUserService, UserService>();
			services.AddTransient<ICertificateService, CertificateService>();
			services.AddTransient<ICommonService, CommonService>();
			services.AddTransient<IOrganizationService, OrganizationService>();
			services.AddTransient<IBranchService, BranchService>();
			services.AddTransient<IStatisticService, StatisticService>();
		}
	}
}
