using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.Caching;
public class CacheRemoveAspect : MethodInterception
{
	private string _pattern;
	private ICacheManager _cacheManager;

	public CacheRemoveAspect(string pattern)
	{
		_pattern = pattern;
		_cacheManager = CoreServiceRegistration.ServiceProvider.GetService<ICacheManager>();
	}

	protected override void OnSuccess(IInvocation invocation)
	{
		_cacheManager.RemoveByPattern(_pattern);
	}
}