using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class UserApplicationConfiguration : IEntityTypeConfiguration<UserApplication>
    {
        public void Configure(EntityTypeBuilder<UserApplication> builder)
        {
            builder.Ignore(ua => ua.Id);
            builder.HasKey(ua => new { ua.UserId, ua.ApplicationId });

            builder.Property(ua => ua.UserId).HasColumnName("UserId").IsRequired();
            builder.Property(ua => ua.ApplicationId).HasColumnName("ApplicationId").IsRequired();

            builder.HasQueryFilter(us => !us.DeletedDate.HasValue);

            builder.HasOne(ua => ua.User);
            builder.HasOne(ua => ua.Application);
        }
    }

}
