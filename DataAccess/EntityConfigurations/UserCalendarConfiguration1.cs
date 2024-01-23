using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
	public class UserCalendarConfiguration : IEntityTypeConfiguration<UserCalendar>
	{
		public void Configure(EntityTypeBuilder<UserCalendar> builder)
		{
			builder.Ignore(u => u.Id);
			builder.ToTable("UserCalendars").HasKey(u => new { u.UserId, u.CalenderId });

			builder.Property(u => u.UserId).HasColumnName("UserId").IsRequired();
			builder.Property(u => u.CalenderId).HasColumnName("CalenderId").IsRequired();

			builder.HasQueryFilter(u => !u.DeletedDate.HasValue);
		}
	}
}
