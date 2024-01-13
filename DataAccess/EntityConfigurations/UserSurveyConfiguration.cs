using Entities.Concretes.CrossTable;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class UserSurveyConfiguration : IEntityTypeConfiguration<UserSurvey>
    {
        public void Configure(EntityTypeBuilder<UserSurvey> builder)
        {
            builder.Ignore(u => u.Id);
            builder.ToTable("UserSurveys").HasKey(u => new { u.UserId, u.SurveyId });

            builder.Property(u => u.UserId).HasColumnName("UserId").IsRequired();
            builder.Property(u => u.SurveyId).HasColumnName("SurveyId").IsRequired();

            builder.HasQueryFilter(u => !u.DeletedDate.HasValue);

            builder.HasOne(u => u.User);
            builder.HasOne(u => u.Survey);
        }
    }
}
