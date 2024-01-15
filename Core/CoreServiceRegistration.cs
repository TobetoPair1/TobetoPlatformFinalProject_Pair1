using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Core
{
	public static class CoreServiceRegistration
    {        
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {		
			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			services.AddSingleton<ICacheManager, MemoryCacheManager>();
			services.BuildServiceProvider();
			return services;
        }
    }
}
