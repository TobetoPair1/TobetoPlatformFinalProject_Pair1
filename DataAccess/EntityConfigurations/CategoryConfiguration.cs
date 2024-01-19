using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories").HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.Name).HasColumnName("Name").IsRequired();

			builder.HasIndex(u => u.Name, "UK_Categories_Name").IsUnique();

			builder.HasQueryFilter(c => !c.DeletedDate.HasValue);

			builder.HasMany(c => c.Courses).WithOne(c => c.Category).HasForeignKey(c => c.CategoryId);
			builder.HasMany(c => c.LiveContents).WithOne(lc => lc.Category).HasForeignKey(lc => lc.CategoryId);
			builder.HasMany(c => c.AsyncContents).WithOne(ac => ac.Category).HasForeignKey(ac => ac.CategoryId);
			builder.HasMany(c => c.Assignments).WithOne(a => a.Category).HasForeignKey(a => a.CategoryId);
		}
    }

}
