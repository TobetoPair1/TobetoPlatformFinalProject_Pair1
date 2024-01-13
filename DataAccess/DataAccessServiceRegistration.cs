﻿using DataAccess.Abstracts;
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
            
#if _WINDOWS
            services.AddDbContext<TobetoPlatformContext>(options => options.UseSqlServer(configuration.GetConnectionString("TobetoPlatform")));
#else
            services.AddDbContext<TobetoPlatformContext>(options => options.UseSqlServer(configuration.GetConnectionString("TobetoPlatform2")));
#endif
            
            services.AddScoped<IUserDal, EfUserDal>();
            services.AddScoped<IPersonalInfoDal, EfPersonalInfoDal>();
            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
            services.AddScoped<IExperienceDal, EfExperienceDal>();
            services.AddScoped<IEducationDal, EfEducationDal>();
            services.AddScoped<ISkillDal, EfSkillDal>();
            services.AddScoped<IUserSkillDal, EfUserSkillDal>();
            services.AddScoped<ICertificateDal, EfCertificateDal>();
            services.AddScoped<IForeignLanguageDal, EfForeignLanguageDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();


            return services;
        }
    }
}
