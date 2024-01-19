using Core.Entities;
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

			builder.Property(u => u.Id).HasColumnName("Id").IsRequired();
			builder.Property(u => u.FirstName).HasColumnName("FirstName").IsRequired();
			builder.Property(u => u.LastName).HasColumnName("LastName").IsRequired();
			builder.Property(u => u.PasswordHash).HasColumnName("PasswordHash").IsRequired();
			builder.Property(u => u.PasswordSalt).HasColumnName("PasswordSalt").IsRequired();
			builder.Property(u => u.Email).HasColumnName("Email").IsRequired();
			builder.Property(u => u.Status).HasColumnName("Status").IsRequired();
			builder.Property(u => u.IsInstructor).HasColumnName("IsInstructor").IsRequired();

			builder.HasIndex(u => u.Email, "UK_Users_Email").IsUnique();

			builder.HasQueryFilter(u => !u.DeletedDate.HasValue);
			builder.HasOne(u => u.PersonalInfo).WithOne(pi => pi.User).HasForeignKey<PersonalInfo>(pi => pi.UserId);
			builder.HasMany(u => u.Certificates).WithOne(c => c.User).HasForeignKey(c => c.UserId);
			builder.HasMany(u => u.SocialMedias).WithOne(sm => sm.User).HasForeignKey(sm => sm.UserId);
			builder.HasMany(u => u.Experiences).WithOne(e => e.User).HasForeignKey(e => e.UserId);
			builder.HasMany(u => u.Educations).WithOne(e => e.User).HasForeignKey(e => e.UserId);
			builder.HasMany(u => u.ForeignLanguages).WithOne(fl => fl.User).HasForeignKey(fl => fl.UserId);
			builder.HasMany(u => u.Applications).WithOne(ua => ua.User).HasForeignKey(ua => ua.UserId);
			builder.HasMany(u => u.Exams).WithOne(ue => ue.User).HasForeignKey(ue => ue.UserId);
			builder.HasMany(u => u.Surveys).WithOne(us => us.User).HasForeignKey(us => us.UserId);
			builder.HasMany(u => u.Courses).WithOne(uc => uc.User).HasForeignKey(e => e.UserId);
			builder.HasMany(u => u.Likes).WithOne(ul => ul.User).HasForeignKey(ul => ul.UserId);
			builder.HasMany(u => u.Skills).WithOne(us => us.User).HasForeignKey(us => us.UserId);
			builder.HasMany(u => u.Favorites).WithOne(uf => uf.User).HasForeignKey(uf => uf.UserId);
			builder.HasMany(u => u.Claims).WithOne(uc => uc.User).HasForeignKey(uc => uc.UserId);
			builder.HasMany(u => u.Files).WithOne(f => f.User).HasForeignKey(f => f.UserId);
		}
	}
}
