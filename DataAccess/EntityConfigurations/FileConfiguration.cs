using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using File = Entities.Concretes.File;

namespace DataAccess.EntityConfigurations;
public class FileConfiguration : IEntityTypeConfiguration<File>
{
    public void Configure(EntityTypeBuilder<File> builder)
    {
        builder.ToTable("Files").HasKey(f => f.Id);

        builder.Property(f => f.Id).HasColumnName("Id").IsRequired();
        builder.Property(f => f.AssignmentId).HasColumnName("AssignmentId").IsRequired();
        builder.Property(f => f.UserId).HasColumnName("UserId").IsRequired();
        builder.Property(f => f.FilePath).HasColumnName("FilePath").IsRequired();

        builder.HasQueryFilter(f => !f.DeletedDate.HasValue);

		builder.HasMany(f => f.Homeworks).WithOne(hm=>hm.File).HasForeignKey(hm=>hm.FileId);
	}
}