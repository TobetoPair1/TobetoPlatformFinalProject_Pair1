using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class SurveyConfiguration : IEntityTypeConfiguration<Survey>
{
    public void Configure(EntityTypeBuilder<Survey> builder)
    {
        builder.ToTable("Surveys").HasKey(s => s.Id);

        builder.Property(s => s.Id).HasColumnName("Id").IsRequired();
        builder.Property(s => s.Title).HasColumnName("Title").IsRequired();
        builder.Property(s => s.Description).HasColumnName("Description").IsRequired();
        builder.Property(s => s.FormUrl).HasColumnName("FormUrl").IsRequired();

        builder.HasQueryFilter(s => !s.DeletedDate.HasValue);

		builder.HasMany(s => s.Users).WithOne(us => us.Survey).HasForeignKey(us => us.SurveyId);
	}
}