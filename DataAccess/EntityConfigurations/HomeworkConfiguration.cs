using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
	public class HomeworkConfiguration : IEntityTypeConfiguration<Homework>
	{
		public void Configure(EntityTypeBuilder<Homework> builder)
		{
			builder.ToTable("Homeworks").HasKey(h => h.Id);

			builder.Property(h => h.Id).HasColumnName("Id").IsRequired();
			builder.Property(h => h.CategoryId).HasColumnName("CategoryId").IsRequired();
			builder.Property(h => h.LikeId).HasColumnName("LikeId").IsRequired();
			builder.Property(h => h.CourseId).HasColumnName("CourseId").IsRequired();
			builder.Property(h => h.Name).HasColumnName("Name").IsRequired();
			builder.Property(c => c.Title).HasColumnName("ImageUrl").IsRequired();
			builder.Property(c => c.IsCompleted).HasColumnName("IsCompleted").IsRequired();
			builder.Property(c => c.EndOfDate).HasColumnName("EndOfDate").IsRequired();
			builder.Property(c => c.InstructorDescription).HasColumnName("InstructorDescription").IsRequired();
			builder.Property(c => c.StudentDescription).HasColumnName("StudentDescription").IsRequired();

			builder.HasQueryFilter(c => !c.DeletedDate.HasValue);

			builder.HasOne(c => c.Category);
			builder.HasOne(c => c.Like);
			builder.HasOne(c => c.Course);
			builder.HasMany(c => c.Files);
		}
	}
}
