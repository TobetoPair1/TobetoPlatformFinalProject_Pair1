using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.Caching;
public class CacheAspect : MethodInterception
{
	private int _duration;
	private ICacheManager _cacheManager;

	public CacheAspect(int duration = 60)
	{
		_duration = duration;			
		_cacheManager = CoreServiceRegistration.ServiceProvider.GetService<ICacheManager>();
	}

	public override void Intercept(IInvocation invocation)
	{
		var methodName = string.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}");
		var arguments = invocation.Arguments.ToList();
		Dictionary<string, string> values = new();
		foreach (var argument in arguments)
		{			
			var argProperties = argument.GetType().GetProperties()
	.ToDictionary(p => p.Name, p => p.GetValue(argument)?.ToString() ?? "<Null>");
            foreach (var item in argProperties)
            {
				values.Add(item.Key,item.Value);
            }
        }
		
		var key = $"{methodName}({string.Join(",", arguments.Select(x => x?.ToString() ?? "<Null>"))})({string.Join(",", values.Select(x => x.ToString() ?? "<Null>"))})";
		if (_cacheManager.IsAdd(key))
		{
			invocation.ReturnValue = _cacheManager.Get(key);
			return;
		}
		invocation.Proceed();
		_cacheManager.Add(key, invocation.ReturnValue, _duration);
	}
}