using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            builder.Property(c => c.LiveContentId).HasColumnName("LiveContentId").IsRequired();
            builder.Property(c => c.AsyncContentId).HasColumnName("AsyncContentId").IsRequired();
            builder.Property(c => c.CourseId).HasColumnName("CourseId").IsRequired();

            builder.HasMany(c => c.Courses).WithOne(co => co.Category).HasForeignKey(co => co.CategoryId);
            builder.HasMany(c => c.LiveContents).WithOne(lc => lc.Category).HasForeignKey(lc => lc.CategoryId);
            builder.HasMany(c => c.AsyncContents).WithOne(ac => ac.Category).HasForeignKey(ac => ac.CategoryId);

            builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        }
    }

}
