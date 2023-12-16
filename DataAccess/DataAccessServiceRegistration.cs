using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class DataAccessServiceRegistration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TobetoPlatformContext>(options => options.UseSqlServer(configuration.GetConnectionString("TobetoPlatform")));
            services.AddScoped<IUserDal, EfUserDal>();
            services.AddScoped<IPersonalInfoDal, EfPersonalInfoDal>();

            return services;
        }
    }
}
