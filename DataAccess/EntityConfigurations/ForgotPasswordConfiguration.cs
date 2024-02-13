using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;
public class ForgotPasswordConfiguration : IEntityTypeConfiguration<ForgotPassword>
{
    public void Configure(EntityTypeBuilder<ForgotPassword> builder)
    {
        builder.ToTable("ForgotPasswords").HasKey(f => f.Id);

        builder.Property(f => f.Id).HasColumnName("Id").IsRequired();
        builder.Property(f => f.UserId).HasColumnName("UserId").IsRequired();
        builder.Property(f => f.Code).HasColumnName("Code").IsRequired();

        builder.HasQueryFilter(f => !f.DeletedDate.HasValue);
    }
}