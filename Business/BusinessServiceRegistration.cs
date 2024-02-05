using Business.Abstracts;
using Business.Concretes;
using Core.Business.Rules;
using Core.Entities;
using Core.Utilities.Security.Jwt;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business;

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
        services.AddScoped<IAnnouncementService, AnnouncementManager>();
        services.AddScoped<IAnswerService, AnswerManager>();
        services.AddScoped<IApplicationService, ApplicationManager>();
        services.AddScoped<IAssignmentService, AssignmentManager>();
        services.AddScoped<IAsyncContentService, AsyncContentManager>();
        services.AddScoped<ICategoryService, CategoryManager>();
        services.AddScoped<ICourseAsyncContentService, CourseAsyncContentManager>();
        services.AddScoped<ICourseLiveContentService, CourseLiveContentManager>();
        services.AddScoped<ICourseService, CourseManager>();
        services.AddScoped<IExamQuestionService, ExamQuestionManager>();
        services.AddScoped<IFavouriteService, FavouriteManager>();
        services.AddScoped<IFileService, FileManager>();
        services.AddScoped<IHomeworkFileService, HomeworkFileManager>();
        services.AddScoped<IHomeworkService, HomeworkManager>();
        services.AddScoped<ICourseAsyncContentService, CourseAsyncContentManager>();
        services.AddScoped<IInstructorService, InstructorManager>();
        services.AddScoped<ILikeService, LikeManager>();
        services.AddScoped<ILiveContentService, LiveContentManager>();
        services.AddScoped<IQuestionService, QuestionManager>();
        services.AddScoped<ISessionService, SessionManager>();
        services.AddScoped<ISurveyService, SurveyManager>();
        services.AddScoped<IUserApplicationService, UserApplicationManager>();
        services.AddScoped<IUserCourseService, UserCourseManager>();
        services.AddScoped<IUserExamService, UserExamManager>();
        services.AddScoped<IUserSurveyService, UserSurveyManager>();

        var assembly = Assembly.GetExecutingAssembly();
        services.AddAutoMapper(assembly);
        services.AddSubClassesOfType(assembly, typeof(BaseBusinessRules<Entity<Guid>>));
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
