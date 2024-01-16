using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
	public class UserExamConfiguration : IEntityTypeConfiguration<UserExam>
	{
		public void Configure(EntityTypeBuilder<UserExam> builder)
		{
			builder.Ignore(ue=>ue.Id);
			builder.ToTable("UserExams").HasKey(ue => new { ue.ExamId,ue.UserId});
			
			builder.Property(ue => ue.UserId).HasColumnName("UserId").IsRequired();
			builder.Property(ue => ue.ExamId).HasColumnName("ExamId").IsRequired();

			builder.HasQueryFilter(u => !u.DeletedDate.HasValue);

			builder.HasOne(ue => ue.User);
			builder.HasOne(ue => ue.Exam);
		}
	}
}
