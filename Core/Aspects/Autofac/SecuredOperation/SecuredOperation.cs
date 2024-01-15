using Castle.DynamicProxy;
using Core.Extensions;
using Core.Utilities.Interceptors;
using Microsoft.AspNetCore.Http;

namespace Business.BusinessAspects.Autofac
{
	public class SecuredOperation : MethodInterception
	{
		private string[] _roles;
		private IHttpContextAccessor _httpContextAccessor;

		public SecuredOperation(IHttpContextAccessor httpContextAccessor, string roles)
		{
			_roles = roles.Split(',');
			_httpContextAccessor = httpContextAccessor;

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
			throw new Exception("Erişim engellendi.");
		}
	}
}
