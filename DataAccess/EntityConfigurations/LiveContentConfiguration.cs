using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class LiveContentConfiguration : IEntityTypeConfiguration<LiveContent>
{
    public void Configure(EntityTypeBuilder<LiveContent> builder)
    {
        builder.ToTable("LiveContents").HasKey(l => l.Id);

        builder.Property(l => l.Id).HasColumnName("Id").IsRequired();
        builder.Property(l => l.CategoryId).HasColumnName("CategoryId").IsRequired();
        builder.Property(l => l.LikeId).HasColumnName("LikeId").IsRequired();
        builder.Property(l => l.Title).HasColumnName("Title").IsRequired();
        builder.Property(l => l.Name).HasColumnName("Name").IsRequired();
        builder.Property(l => l.IsCompleted).HasColumnName("IsCompleted").IsRequired();

        builder.HasQueryFilter(l => !l.DeletedDate.HasValue);
        
        builder.HasMany(l => l.Sessions).WithOne(s => s.LiveContent).HasForeignKey(s => s.LiveContentId);
		builder.HasMany(l => l.Courses).WithOne(cl => cl.LiveContent).HasForeignKey(cl => cl.LiveContentId);
		builder.HasMany(l => l.LikedByUsers).WithOne(cl => cl.LiveContent).HasForeignKey(cl => cl.ContentId);
		builder.HasMany(l => l.Homeworks).WithOne(cl => cl.LiveContent).HasForeignKey(cl => cl.LiveContentId);
    }
}