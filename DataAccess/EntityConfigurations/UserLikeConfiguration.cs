using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class UserLikeConfiguration : IEntityTypeConfiguration<UserLike>
    {
        public void Configure(EntityTypeBuilder<UserLike> builder)
        {
            builder.ToTable("UserLikes").HasKey(ul => new { ul.UserId, ul.LikeId });

            builder.Property(ul => ul.UserId).HasColumnName("UserId").IsRequired();
            builder.Property(ul => ul.LikeId).HasColumnName("LikeId").IsRequired();

            builder.HasQueryFilter(ul => !ul.DeletedDate.HasValue);
        }
    }

}
