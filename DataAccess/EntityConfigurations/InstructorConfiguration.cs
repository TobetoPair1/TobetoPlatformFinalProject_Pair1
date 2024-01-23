using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
	public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors").HasKey(i => i.Id);

            builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
            builder.Property(i=>i.FullName).HasColumnName("FullName").IsRequired();

            builder.HasQueryFilter(i => !i.DeletedDate.HasValue);

            builder.HasMany(i => i.Sessions).WithOne(ins=>ins.Instructor).HasForeignKey(ins=>ins.InstructorId);
            builder.HasMany(i => i.Calendars).WithOne(c=>c.Instructor).HasForeignKey(c=>c.InstructorId);
        }
    }
}
