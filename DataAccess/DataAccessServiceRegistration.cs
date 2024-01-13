using Core.Entities;
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
            services.AddScoped<IAnswerDal, EfAnswerDal>();
            services.AddScoped<IApplicationDal, EfApplicationDal>();
            services.AddScoped<IAssignmentDal, EfAssignmentDal>();
            services.AddScoped<IAsyncContentDal, EfAsyncContentDal>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICourseAsyncContentDal, EfCourseAsyncContentDal>();
            services.AddScoped<ICourseDal, EfCourseDal>();
            services.AddScoped<ICourseLiveContentDal, EfCourseLiveContentDal>();
            services.AddScoped<IExamDal, EfExamDal>();
            services.AddScoped<IFavouriteDal, EfFavouriteDal>();
            services.AddScoped<IFileDal, EfFileDal>();
            services.AddScoped<IHomeworkDal, EfHomeworkDal>();
            services.AddScoped<IInstructorDal, EfInstructorDal>();
            services.AddScoped<ILikeDal, EfLikeDal>();
            services.AddScoped<ILiveContentDal, EfLiveContentDal>();
            services.AddScoped<IOperationClaimDal, EfOperationClaimDal>();
            services.AddScoped<IQuestionDal, EfQuestionDal>();
            services.AddScoped<ISurveyDal, EfSurveyDal>();
            services.AddScoped<IUserApplicationDal, EfUserApplicationDal>();
            services.AddScoped<IUserCourseDal, EfUserCourseDal>();
            services.AddScoped<IUserSurveyDal, EfUserSurveyDal>();
            services.AddScoped<IUserExamDal, EfUserExamDal>();
            services.AddScoped<IUserFavouriteDal, EfUserFavouriteDal>();
            services.AddScoped<IUserLikeDal, EfUserLikeDal>();
            services.AddScoped<IUserOperationClaimDal, EfUserOperationClaimDal>();


            return services;
        }
    }
}
