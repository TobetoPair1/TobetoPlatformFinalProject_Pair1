using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class HomeworkFileConfiguration : IEntityTypeConfiguration<HomeworkFile>
    {
        public void Configure(EntityTypeBuilder<HomeworkFile> builder)
        {
            builder.Ignore(h => h.Id);
            builder.ToTable("HomeworkFile").HasKey(h => new {h.FileId,h.HomeworkId});

            builder.Property(h => h.Id).HasColumnName("Id").IsRequired();
            builder.Property(h => h.FileId).HasColumnName("FileId").IsRequired();
            builder.Property(h => h.HomeworkId).HasColumnName("HomeworkId").IsRequired();

            builder.HasQueryFilter(h => !h.DeletedDate.HasValue);

            builder.HasOne(h => h.File);
            builder.HasOne(h => h.Homework);
        }
    }
}
