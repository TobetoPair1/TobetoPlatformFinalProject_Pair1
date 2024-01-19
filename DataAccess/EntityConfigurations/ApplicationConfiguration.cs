using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {
            builder.ToTable("Applications").HasKey(a => a.Id);

            builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.Title).HasColumnName("Title").IsRequired();
            builder.Property(a => a.FormUrl).HasColumnName("FormUrl").IsRequired();
            builder.Property(a => a.State).HasColumnName("State").IsRequired();

            builder.HasQueryFilter(a => !a.DeletedDate.HasValue);

			builder.HasMany(a => a.Users).WithOne(ua => ua.Application).HasForeignKey(ua => ua.ApplicationId);
		}
	}
}
