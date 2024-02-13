using Entities.Concretes;
using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace DataAccess.Contexts;

public class TobetoPlatformContext:DbContext
{
    protected IConfiguration Configuration { get; set; }

    public DbSet<User> Users { get; set; }
    public DbSet<PersonalInfo> PersonalInfos { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Certificate> Certificates { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<UserSkill> UserSkills { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<ForeignLanguage> ForeignLanguages { get; set; }
    public DbSet<OperationClaim> OperationClaims { get; set; }
    public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    public DbSet<Announcement> Announcements { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<Application> Applications { get; set; }
    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<AsyncContent> AsyncContents { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<CourseAsyncContent> CourseAsyncContents { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseLiveContent> CourseLiveContents { get; set; }
    public DbSet<Exam> Exams { get; set; }
    public DbSet<ExamQuestion> ExamQuestions { get; set; }
    public DbSet<Favourite> Favourites { get; set; }
    public DbSet<Entities.Concretes.File> Files { get; set; }
    public DbSet<Homework> Homeworks { get; set; }
    public DbSet<HomeworkFile> HomeworkFiles { get; set; }
    public DbSet<Like> Likes { get; set; }
    public DbSet<LiveContent> LiveContents { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Survey> Surveys { get; set; }
    public DbSet<UserSurvey> UserSurveys { get; set; }
    public DbSet<UserApplication> UserApplications { get; set; }
    public DbSet<UserCourse> UserCourses { get; set; }
    public DbSet<UserExam> UserExams { get; set; }
    public DbSet<Calendar> Calendars { get; set; }
    public DbSet<UserCalendar> UserCalendars { get; set; }
    public DbSet<InstructorSession> InstructorSessions { get; set; }
    public DbSet<CourseLikedByUser> CourseLikedByUsers { get; set; }
    public DbSet<ContentLikedByUser> ContentLikedByUsers { get; set; }
    public DbSet<CourseFavouritedByUser> CourseFavouritedByUsers { get; set; }
    public DbSet<ForgotPassword> ForgotPasswords { get; set; }

    public TobetoPlatformContext(DbContextOptions options, IConfiguration configuration):base(options)
    {
        Configuration = configuration;
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}