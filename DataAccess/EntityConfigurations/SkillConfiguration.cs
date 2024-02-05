using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class SkillConfiguration : IEntityTypeConfiguration<Skill>
{
	public void Configure(EntityTypeBuilder<Skill> builder)
	{
		builder.ToTable("Skills").HasKey(s => s.Id);

		builder.Property(s => s.Id).HasColumnName("Id").IsRequired();
		builder.Property(s => s.Name).HasColumnName("Name").IsRequired();

		builder.HasIndex(indexExpression: s => s.Name, name: "UK_Skills_Name").IsUnique();

		builder.HasQueryFilter(s => !s.DeletedDate.HasValue);

		builder.HasMany(s => s.Users).WithOne(us=>us.Skill).HasForeignKey(us=>us.SkillId);
	}
}