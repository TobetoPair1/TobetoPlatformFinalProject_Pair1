using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class CourseAsyncContentConfiguration : IEntityTypeConfiguration<CourseAsyncContent>
    {
        public void Configure(EntityTypeBuilder<CourseAsyncContent> builder)
        {

            builder.Ignore(ca => ca.Id);
            builder.HasKey(ca => new { ca.CourseId, ca.AsyncContentId });

            builder.Property(ca => ca.CourseId).HasColumnName("CourseId").IsRequired();
            builder.Property(ca => ca.AsyncContentId).HasColumnName("AsyncContentId").IsRequired();

            builder.HasQueryFilter(ca => !ca.DeletedDate.HasValue);

           

        }
    }
}
