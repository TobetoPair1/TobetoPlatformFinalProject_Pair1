using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class ExamQuestionConfiguration : IEntityTypeConfiguration<ExamQuestion>
{
    public void Configure(EntityTypeBuilder<ExamQuestion> builder)
    {
        builder.Ignore(eq => eq.Id);
        builder.ToTable("ExamQuestions").HasKey(eq =>new { eq.ExamId,eq.QuestionId });
        
        builder.Property(eq => eq.ExamId).HasColumnName("ExamId").IsRequired();
        builder.Property(eq => eq.QuestionId).HasColumnName("QuestionId").IsRequired();

        builder.HasQueryFilter(eq => !eq.DeletedDate.HasValue);
    }
}