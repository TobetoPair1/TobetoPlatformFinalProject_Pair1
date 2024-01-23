using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{

	public class InstructorCalendarConfiguration : IEntityTypeConfiguration<InstructorCalendar>
	{
		public void Configure(EntityTypeBuilder<InstructorCalendar> builder)
		{
			builder.Ignore(ins => ins.Id);
			builder.ToTable("InstructorCalendars").HasKey(ins => new { ins.CalendarId, ins.InstructorId });

			builder.Property(ins => ins.CalendarId).HasColumnName("CalendarId").IsRequired();
			builder.Property(ins => ins.InstructorId).HasColumnName("InstructorId").IsRequired();

			builder.HasQueryFilter(ins => !ins.DeletedDate.HasValue);
		}
	}
}