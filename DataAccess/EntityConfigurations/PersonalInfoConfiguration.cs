using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class PersonalInfoConfiguration : IEntityTypeConfiguration<PersonalInfo>
{
	public void Configure(EntityTypeBuilder<PersonalInfo> builder)
	{
		builder.ToTable("PersonalInfos").HasKey(pi => pi.Id);

		builder.Property(pi => pi.Id).HasColumnName("Id").IsRequired();
		builder.Property(pi => pi.UserId).HasColumnName("UserId").IsRequired();
		builder.Property(pi => pi.IdentityNumber).HasColumnName("IdentityNumber").IsRequired(false);
		builder.Property(pi => pi.PhoneNumber).HasColumnName("PhoneNumber").IsRequired(false);
		builder.Property(pi => pi.Country).HasColumnName("Country").IsRequired(false);
		builder.Property(pi => pi.City).HasColumnName("City").IsRequired(false);
		builder.Property(pi => pi.District).HasColumnName("District").IsRequired(false);
		builder.Property(pi => pi.Address).HasColumnName("Address").IsRequired(false);
		builder.Property(pi => pi.About).HasColumnName("About").IsRequired(false);
		builder.Property(pi => pi.ProfileImageUrl).HasColumnName("ProfileImageUrl").IsRequired(false);

		builder.HasQueryFilter(pi => !pi.DeletedDate.HasValue);
	}
}