using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
	public class CourseFavouritedByUserConfiguration : IEntityTypeConfiguration<CourseFavouritedByUser>
    {
        public void Configure(EntityTypeBuilder<CourseFavouritedByUser> builder)
        {
            builder.Ignore(uf => uf.Id);
            builder.ToTable("CourseFavouritedByUsers").HasKey(uf => new { uf.UserId, uf.CourseId });

            builder.Property(uf => uf.UserId).HasColumnName("UserId").IsRequired();
            builder.Property(uf => uf.CourseId).HasColumnName("CourseId").IsRequired();

            builder.HasQueryFilter(uf => !uf.DeletedDate.HasValue);
        }
    }
}