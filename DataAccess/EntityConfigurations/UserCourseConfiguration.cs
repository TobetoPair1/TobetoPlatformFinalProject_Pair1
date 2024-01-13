using Entities.Concretes.CrossTable;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class UserCourseConfiguration : IEntityTypeConfiguration<UserCourse>
    {
        public void Configure(EntityTypeBuilder<UserCourse> builder)
        {
            builder.Ignore(u => u.Id);
            builder.ToTable("UserCourse").HasKey(u => new {u.UserId,u.CourseId});

            builder.Property(u => u.UserId).HasColumnName("UserId").IsRequired();
            builder.Property(u => u.CourseId).HasColumnName("CourseId").IsRequired();

            builder.HasQueryFilter(u => !u.DeletedDate.HasValue);

            builder.HasOne(u => u.Course);
            builder.HasOne(u => u.User);
        }
    }
}
