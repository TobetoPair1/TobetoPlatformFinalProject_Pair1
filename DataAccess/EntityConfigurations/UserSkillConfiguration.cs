using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class UserSkillConfiguration : IEntityTypeConfiguration<UserSkill>
	{
		public void Configure(EntityTypeBuilder<UserSkill> builder)
		{
			builder.Ignore(us => us.Id);
			builder.ToTable("UserSkills").HasKey(us => new {us.UserId,us.SkillId});
			
			builder.Property(us => us.UserId).HasColumnName("UserId").IsRequired();
			builder.Property(us => us.SkillId).HasColumnName("SkillId").IsRequired();

			builder.HasQueryFilter(us => !us.DeletedDate.HasValue);
		}
	}
}
