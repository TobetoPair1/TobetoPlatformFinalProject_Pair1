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
			builder.HasKey(us => new {us.UserId,us.SkillId});
			
			builder.Property(us => us.UserId).HasColumnName("UserId").IsRequired();
			builder.Property(us => us.SkillId).HasColumnName("SkillId").IsRequired();

			builder.HasQueryFilter(us => !us.DeletedDate.HasValue);

			builder.HasOne(us => us.User);
			builder.HasOne(us => us.Skill);
			//builder.HasOne(us => us.User).WithMany(u => u.Skills).HasForeignKey(us => us.UserId);
			//builder.HasOne(us => us.Skill).WithMany(s => s.Users).HasForeignKey(us => us.SkillId);
		}
	}
}
