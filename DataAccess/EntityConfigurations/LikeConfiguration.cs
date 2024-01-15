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


			builder.HasMany(l => l.Users);
            builder.HasOne(l => l.Course);
            builder.HasOne(l => l.AsyncContent);
            builder.HasOne(l => l.LiveContent);           
        }
    }
}
