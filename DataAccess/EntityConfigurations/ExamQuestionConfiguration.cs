using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concretes.CrossTable;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class ExamQuestionConfiguration : IEntityTypeConfiguration<ExamQuestion>
    {
        public void Configure(EntityTypeBuilder<ExamQuestion> builder)
        {
            builder.ToTable("ExamQuestions").HasKey(eq => eq.Id);

            builder.Property(eq => eq.Id).HasColumnName("Id").IsRequired();
            builder.Property(eq => eq.ExamId).HasColumnName("ExamId").IsRequired();
            builder.Property(eq => eq.QuestionId).HasColumnName("QuestionId").IsRequired();

            builder.HasOne(eq => eq.Exam).WithMany(e => e.Questions).HasForeignKey(eq => eq.ExamId);
            builder.HasOne(eq => eq.Question).WithMany(q => q.Exams).HasForeignKey(eq => eq.QuestionId);

            builder.HasQueryFilter(eq => !eq.DeletedDate.HasValue);
        }
    }

}
