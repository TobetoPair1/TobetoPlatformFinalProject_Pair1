using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class UserFavouriteConfiguration : IEntityTypeConfiguration<UserFavourite>
    {
        public void Configure(EntityTypeBuilder<UserFavourite> builder)
        {
            builder.Ignore(uf => uf.Id);
            builder.HasKey(uf => new { uf.UserId, uf.FavouriteId });

            builder.Property(uf => uf.UserId).HasColumnName("UserId").IsRequired();
            builder.Property(uf => uf.FavouriteId).HasColumnName("FavouriteId").IsRequired();

            builder.HasQueryFilter(uf => !uf.DeletedDate.HasValue);

            builder.HasOne(uf => uf.User);
            builder.HasOne(uf => uf.Favourite);
        }
    }
}
