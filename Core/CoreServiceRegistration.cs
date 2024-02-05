using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace Core;
public static class CoreServiceRegistration
{	
    public static IServiceProvider ServiceProvider { get; private set; }
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        services.AddMemoryCache();
			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			services.AddSingleton<ICacheManager, MemoryCacheManager>();
			services.AddSingleton<Stopwatch>();
        ServiceProvider=services.BuildServiceProvider();
			return services;
    }
}