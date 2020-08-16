using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DataAccess.Database;
using DataAccess.UnitofWork;

namespace Web.Installers
{
	public class DbInstaller : IInstaller
	{
		public void InstallServices(IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContextPool<DataContext>(options =>
				options.UseSqlServer(
					configuration.GetConnectionString("DefaultConnection")));

			services.AddTransient<DbContext, DataContext>();
			services.AddTransient<IUnitOfWork, UnitOfWork>();
		}
	}
}
