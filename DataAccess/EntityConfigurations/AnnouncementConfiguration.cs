using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class AnnouncementConfiguration : IEntityTypeConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
            builder.ToTable("Announcements").HasKey(t => t.Id);
            builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.Header).HasColumnName("Header").IsRequired();
            builder.Property(a => a.Description).HasColumnName("Description").IsRequired();

            builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
        }
    }
}
