using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;
public class InstructorSessionConfiguration : IEntityTypeConfiguration<InstructorSession>
{
	public void Configure(EntityTypeBuilder<InstructorSession> builder)
	{
		builder.Ignore(ins => ins.Id);
		builder.ToTable("InstructorSessions").HasKey(ins => new { ins.SessionId, ins.InstructorId});
		
		builder.Property(ins => ins.SessionId).HasColumnName("SessionId").IsRequired();
		builder.Property(ins => ins.InstructorId).HasColumnName("InstructorId").IsRequired();

		builder.HasQueryFilter(ins => !ins.DeletedDate.HasValue);
	}
}