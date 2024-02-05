using Castle.DynamicProxy;
using Core.Extensions;
using Core.Utilities.Interceptors;
using Core.Utilities.Messages;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.SecuredOperation;
public class SecuredOperation : MethodInterception
{
	private string[] _roles;
	private IHttpContextAccessor _httpContextAccessor;

	public SecuredOperation(string roles)
	{
		_roles = roles.Split(',');
		_httpContextAccessor = CoreServiceRegistration.ServiceProvider.GetService<IHttpContextAccessor>();

	}

	protected override void OnBefore(IInvocation invocation)
	{
		var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
		foreach (var role in _roles)
		{
			if (roleClaims.Contains(role))
			{
				return;
			}
		}
		throw new System.Exception(AspectMessages.AccessDenied);
	}
}