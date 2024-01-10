using Business.Abstracts;
using Business.Concretes;
using Core.Business.Rules;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstracts;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IPersonalInfoService, PersonalInfoManager>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<ICertificateService, CertificateManager>();
            services.AddScoped<IEducationService, EducationManager>();
            services.AddScoped<ISkillService, SkillManager>();
            services.AddScoped<IUserSkillService, UserSkillManager>();
            services.AddScoped<IForeignLanguageService, ForeignLanguageManager>();
            services.AddScoped<IAuthService, AuthManager>();
            services.AddScoped<ITokenHelper, JwtHelper>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddSubClassesOfType(Assembly.GetExecutingAssembly(), typeof(BaseBusinessRules));

            
            return services;
        }       

        public static IServiceCollection AddSubClassesOfType(
                this IServiceCollection services,
                Assembly assembly,
                Type type,
                Func<IServiceCollection,
                Type,
                IServiceCollection>? addWithLifeCycle = null)
        {
            var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
            foreach (var item in types)
                if (addWithLifeCycle == null)
                    services.AddScoped(item);

                else
                    addWithLifeCycle(services, type);
            return services;
        }
    }
}
