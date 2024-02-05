using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
	public class CourseConfiguration : IEntityTypeConfiguration<Course>
	{
		public void Configure(EntityTypeBuilder<Course> builder)
		{
			builder.ToTable("Courses").HasKey(c => c.Id);

			builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
			builder.Property(c => c.CategoryId).HasColumnName("CategoryId").IsRequired();
			builder.Property(c => c.LikeId).HasColumnName("LikeId").IsRequired();
			builder.Property(c => c.Name).HasColumnName("Name").IsRequired();
			builder.Property(c => c.ImageUrl).HasColumnName("ImageUrl").IsRequired();
			builder.Property(c => c.StartOfDate).HasColumnName("StartOfDate").IsRequired();
			builder.Property(c => c.EndOfDate).HasColumnName("EndOfDate").IsRequired();
			builder.Property(c => c.TimeSpent).HasColumnName("TimeSpent").IsRequired();
			builder.Property(c => c.ContentCount).HasColumnName("ContentCount").IsRequired();
			builder.Property(c => c.ProducingCompany).HasColumnName("ProducingCompany").IsRequired();

			builder.HasIndex(c => c.Name, "UK_Courses_Name").IsUnique();


			builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
			
			builder.HasMany(c => c.Homeworks).WithOne(h => h.Course).HasForeignKey(h => h.CourseId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(c => c.Assignments).WithOne(a => a.Course).HasForeignKey(a => a.CourseId).OnDelete(DeleteBehavior.NoAction);

			//crosstables
			builder.HasMany(c => c.Users).WithOne(uc => uc.Course).HasForeignKey(uc => uc.CourseId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(c => c.AsyncContents).WithOne(ca => ca.Course).HasForeignKey(ca => ca.CourseId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(c => c.LiveContents).WithOne(cl => cl.Course).HasForeignKey(cl => cl.CourseId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(c => c.Calendars).WithOne(c => c.Course).HasForeignKey(c => c.CourseId);
			builder.HasMany(c => c.LikedByUsers).WithOne(clbu => clbu.Course).HasForeignKey(clbu => clbu.CourseId);
		}
	}
}
