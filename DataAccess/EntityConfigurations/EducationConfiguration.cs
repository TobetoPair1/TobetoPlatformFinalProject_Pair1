using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class EducationConfiguration : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.ToTable("Educations").HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("Id").IsRequired();
            builder.Property(e => e.UserId).HasColumnName("UserId").IsRequired();
            builder.Property(e => e.EducationLevel).HasColumnName("EducationLevel").IsRequired();
            builder.Property(e => e.University).HasColumnName("University").IsRequired();
            builder.Property(e => e.Department).HasColumnName("Department").IsRequired();
            builder.Property(e => e.StartOfDate).HasColumnName("StartofDate").IsRequired();
            builder.Property(e => e.GraduationYear).HasColumnName("GraduationYear").IsRequired();
            builder.Property(e => e.IsContinued).HasColumnName("IsContinued").IsRequired();


            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
