using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
	internal class AsyncContentConfiguration : IEntityTypeConfiguration<AsyncContent>
	{
		public void Configure(EntityTypeBuilder<AsyncContent> builder)
		{
			builder.ToTable("AsyncContents").HasKey(ac => ac.Id);

			builder.Property(ac => ac.Id).HasColumnName("Id").IsRequired();
			builder.Property(ac => ac.CategoryId).HasColumnName("CategoryId").IsRequired();
			builder.Property(ac => ac.CourseId).HasColumnName("CourseId").IsRequired();
			builder.Property(ac => ac.VideoUrl).HasColumnName("VideoUrl").IsRequired();
			builder.Property(ac => ac.Language).HasColumnName("Language").IsRequired();
			builder.Property(ac => ac.SubType).HasColumnName("SubType").IsRequired();
			builder.Property(ac => ac.Company).HasColumnName("Company").IsRequired();
			builder.Property(ac => ac.Description).HasColumnName("Description").IsRequired();

			builder.HasQueryFilter(ac => !ac.DeletedDate.HasValue);

			builder.HasOne(ac => ac.Category);
			builder.HasMany(ac => ac.Courses);
		}
	}
}
