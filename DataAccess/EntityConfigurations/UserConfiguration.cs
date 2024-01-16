using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users").HasKey(u => u.Id);

            builder.Property(u=>u.Id).HasColumnName("Id").IsRequired();
            builder.Property(u=>u.FirstName).HasColumnName("FirstName").IsRequired();
            builder.Property(u=>u.LastName).HasColumnName("LastName").IsRequired();
            builder.Property(u=>u.PasswordHash).HasColumnName("PasswordHash").IsRequired();
            builder.Property(u=>u.PasswordSalt).HasColumnName("PasswordSalt").IsRequired();
            builder.Property(u=>u.Email).HasColumnName("Email").IsRequired();
            builder.Property(u=>u.Status).HasColumnName("Status").IsRequired();
            builder.Property(u=>u.IsInstructor).HasColumnName("IsInstructor").IsRequired();

            builder.HasIndex(u=>u.Email,"UK_Users_Email").IsUnique();

            builder.HasQueryFilter(u => !u.DeletedDate.HasValue);
            builder.HasOne(u=>u.PersonalInfo);
            builder.HasMany(u=>u.Certificates);
            builder.HasMany(u=>u.SocialMedias);
            builder.HasMany(u=>u.Experiences);
            builder.HasMany(u=>u.Educations);
            builder.HasMany(u=>u.ForeignLanguages);
            builder.HasMany(u=>u.Applications);
            builder.HasMany(u=>u.Exams);
            builder.HasMany(u=>u.Surveys);
            builder.HasMany(u=>u.Courses);
            builder.HasMany(u=>u.Likes);
			builder.HasMany(u => u.Skills);
			builder.HasMany(u => u.Favorites);
			builder.HasMany(u => u.Claims);
			builder.HasMany(u => u.Files);


		}
	}
}
