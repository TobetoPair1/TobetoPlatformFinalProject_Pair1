using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("Questions").HasKey(q => q.Id);

            builder.Property(q => q.Id).HasColumnName("Id").IsRequired();
            builder.Property(q => q.ExamId).HasColumnName("ExamId").IsRequired();
            builder.Property(q => q.TrueAnswerId).HasColumnName("TrueAnswerId").IsRequired();
            builder.Property(q => q.Description).HasColumnName("Description").IsRequired();
            builder.Property(q => q.ImageUrl).HasColumnName("ImageUrl");
            

            builder.HasMany(q => q.Answers).WithOne(a => a.Question).HasForeignKey(a => a.QuestionId);
            builder.HasMany(q => q.Exams).WithOne(eq => eq.Question).HasForeignKey(eq => eq.QuestionId);

            builder.HasQueryFilter(q => !q.DeletedDate.HasValue);
        }
    }
}
