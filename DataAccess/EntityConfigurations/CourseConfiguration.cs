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

			builder.HasQueryFilter(c => !c.DeletedDate.HasValue);

			builder.HasOne(c => c.Category);
			builder.HasOne(c => c.Like);
			builder.HasMany(c => c.Users);
			builder.HasMany(c => c.AsyncContents).WithOne(c=>c.Course).HasForeignKey(c=>c.CourseId).OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(c => c.LiveContents).WithOne(cl => cl.Course).HasForeignKey(cl => cl.CourseId).OnDelete(DeleteBehavior.Restrict);
		}
	}
}
