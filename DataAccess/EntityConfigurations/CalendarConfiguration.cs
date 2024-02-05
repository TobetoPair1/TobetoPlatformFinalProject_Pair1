using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;
public class CalendarConfiguration : IEntityTypeConfiguration<Calendar>
{
	public void Configure(EntityTypeBuilder<Calendar> builder)
	{
		builder.ToTable("Calendars").HasKey(c => c.Id);

		builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
		builder.Property(c => c.InstructorId).HasColumnName("InstructorId").IsRequired();
		builder.Property(c => c.CourseId).HasColumnName("CourseId").IsRequired();
		builder.Property(c => c.IsCompleted).HasColumnName("IsCompleted").IsRequired();
		builder.Property(c => c.IsPurchased).HasColumnName("IsPurchased").IsRequired();
		builder.Property(c => c.Date).HasColumnName("Date").IsRequired();

		builder.HasQueryFilter(c => !c.DeletedDate.HasValue);

		builder.HasMany(c => c.Users).WithOne(uc => uc.Calendar).HasForeignKey(uc => uc.CalenderId);
	}
}