using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class FavouriteConfiguration : IEntityTypeConfiguration<Favourite>
    {
        public void Configure(EntityTypeBuilder<Favourite> builder)
        {
            builder.ToTable("Favourites").HasKey(f => f.Id);

            builder.Property(f => f.Id).HasColumnName("Id").IsRequired();
            builder.Property(f => f.CourseId).HasColumnName("CourseId").IsRequired();
            builder.Property(f => f.Count).HasColumnName("Count").IsRequired();

            //builder.HasOne(f => f.Course).WithMany(c => c.Favourites).HasForeignKey(f => f.CourseId);

            builder.HasMany(f => f.Users).WithOne(uf => uf.Favourite).HasForeignKey(uf => uf.FavouriteId);

            builder.HasQueryFilter(f => !f.DeletedDate.HasValue);
        }
    }


}
