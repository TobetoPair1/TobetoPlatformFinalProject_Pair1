using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class ContentLikedByUserConfiguration : IEntityTypeConfiguration<ContentLikedByUser>
{
	public void Configure(EntityTypeBuilder<ContentLikedByUser> builder)
	{
		builder.Ignore(uf => uf.Id);
		builder.ToTable("ContentLikedByUsers").HasKey(uf => new { uf.UserId, uf.ContentId });

		builder.Property(uf => uf.UserId).HasColumnName("UserId").IsRequired();
		builder.Property(uf => uf.ContentId).HasColumnName("ContentId").IsRequired();

		builder.HasQueryFilter(uf => !uf.DeletedDate.HasValue);
	}
}