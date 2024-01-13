using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    internal class ExamConfiguration
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.ToTable("Exams").HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("Id").IsRequired();
            builder.Property(e => e.Title).HasColumnName("Title").IsRequired();
            builder.Property(e => e.Description).HasColumnName("Description");
            builder.Property(e => e.StartOfDate).HasColumnName("StartOfDate").IsRequired();
            builder.Property(e => e.EndOfTime).HasColumnName("EndOfTime").IsRequired();
            builder.Property(e => e.Time).HasColumnName("Time").IsRequired();
            builder.Property(e => e.IsCompleted).HasColumnName("IsCompleted").IsRequired();
            builder.Property(e => e.QuestionCount).HasColumnName("QuestionCount").IsRequired();
            builder.Property(e => e.Score).HasColumnName("Score").IsRequired();
            builder.Property(e => e.Type).HasColumnName("Type").IsRequired();
            builder.Property(e => e.TrueCount).HasColumnName("TrueCount").IsRequired();
            builder.Property(e => e.FalseCount).HasColumnName("FalseCount").IsRequired();
            builder.Property(e => e.EmptyCount).HasColumnName("EmptyCount").IsRequired();

            builder.HasMany(e => e.Questions).WithOne().HasForeignKey(q => q.ExamId);
            builder.HasMany(e => e.Users).WithOne().HasForeignKey(u => u.ExamId);

            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }

}


