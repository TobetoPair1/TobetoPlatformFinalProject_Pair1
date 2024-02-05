using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class ForeignLanguageConfiguration : IEntityTypeConfiguration<ForeignLanguage>
{
	public void Configure(EntityTypeBuilder<ForeignLanguage> builder)
	{

		builder.ToTable("ForeignLanguages").HasKey(f => f.Id);

		builder.Property(f => f.Id).HasColumnName("Id").IsRequired();
		builder.Property(f => f.UserId).HasColumnName("UserId").IsRequired();
		builder.Property(f => f.Name).HasColumnName("Name").IsRequired();
		builder.Property(f => f.Level).HasColumnName("Level").IsRequired();

		builder.HasQueryFilter(f => !f.DeletedDate.HasValue);
	}
}