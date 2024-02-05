using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class CourseLikedByUserConfiguration : IEntityTypeConfiguration<CourseLikedByUser>
{
    public void Configure(EntityTypeBuilder<CourseLikedByUser> builder)
    {
        builder.Ignore(clbu => clbu.Id);
        builder.ToTable("CourseLikedByUsers").HasKey(clbu => new { clbu.UserId, clbu.CourseId });

        builder.Property(clbu => clbu.UserId).HasColumnName("UserId").IsRequired();
        builder.Property(clbu => clbu.CourseId).HasColumnName("CourseId").IsRequired();

        builder.HasQueryFilter(clbu => !clbu.DeletedDate.HasValue);
    }
}