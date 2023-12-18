using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
	public class UserSkillConfiguration : IEntityTypeConfiguration<UserSkill>
	{
		public void Configure(EntityTypeBuilder<UserSkill> builder)
		{
			builder.ToTable("UserSkills").HasKey(s => s.Id);

			builder.Property(s => s.Id).HasColumnName("Id").IsRequired();
			builder.Property(s => s.UserId).HasColumnName("UserId").IsRequired();
			builder.Property(s => s.SkillId).HasColumnName("SkillId").IsRequired();

			builder.HasQueryFilter(s => !s.DeletedDate.HasValue);

			builder.HasOne(s=>s.User);
			builder.HasOne(s=>s.Skill);
		}
	}
}
