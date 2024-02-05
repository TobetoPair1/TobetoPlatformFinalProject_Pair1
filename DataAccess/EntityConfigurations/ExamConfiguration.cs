using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class ExamConfiguration : IEntityTypeConfiguration<Exam>
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

        builder.HasMany(e => e.Questions).WithOne(eq=>eq.Exam).HasForeignKey(eq=>eq.ExamId);
        builder.HasMany(e => e.Users).WithOne(ue=>ue.Exam).HasForeignKey(ue=>ue.ExamId);

        builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
    }
}