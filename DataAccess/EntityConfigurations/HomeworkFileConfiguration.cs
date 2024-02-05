using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class HomeworkFileConfiguration : IEntityTypeConfiguration<HomeworkFile>
{
    public void Configure(EntityTypeBuilder<HomeworkFile> builder)
    {
        builder.Ignore(h => h.Id);
        builder.ToTable("HomeworkFiles").HasKey(h => new {h.FileId,h.HomeworkId});

        builder.Property(h => h.FileId).HasColumnName("FileId").IsRequired();
        builder.Property(h => h.HomeworkId).HasColumnName("HomeworkId").IsRequired();

        builder.HasQueryFilter(h => !h.DeletedDate.HasValue);
    }
}