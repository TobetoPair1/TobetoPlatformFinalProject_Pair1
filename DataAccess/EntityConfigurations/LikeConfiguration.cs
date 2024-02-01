using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class LikeConfiguration : IEntityTypeConfiguration<Like>
    {

        public void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.ToTable("Likes").HasKey(l => l.Id);

            builder.Property(l => l.Id).HasColumnName("Id").IsRequired();
            builder.Property(l => l.Count).HasColumnName("Count").IsRequired();

			builder.HasQueryFilter(l => !l.DeletedDate.HasValue);
			
            builder.HasOne(l => l.Course).WithOne(c=>c.Like).HasForeignKey<Course>(c=>c.LikeId);
            builder.HasOne(l => l.AsyncContent).WithOne(ac=>ac.Like).HasForeignKey<AsyncContent>(ac=>ac.LikeId);
            builder.HasOne(l => l.LiveContent).WithOne(lc => lc.Like).HasForeignKey<LiveContent>(lc => lc.LikeId);
		}
    }
}
