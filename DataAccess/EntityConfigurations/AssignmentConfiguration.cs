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
    
    public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            
            builder.ToTable("Assignments").HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.Title).HasColumnName("Title").IsRequired();
            //builder.Property(a => a.ContentText).HasColumnName("ContentText").IsRequired();
            builder.Property(a => a.CreatedDate).HasColumnName("CreatedDate").IsRequired();
            //builder.Property(a => a.ModifiedDate).HasColumnName("ModifiedDate");
            builder.Property(a => a.DeletedDate).HasColumnName("DeletedDate");

            builder.HasQueryFilter(a => !a.DeletedDate.HasValue);

            
            builder.Property(a => a.CourseId).HasColumnName("CourseId").IsRequired();
            builder.Property(a => a.Description).HasColumnName("Description").IsRequired();
            builder.Property(a => a.AssignmentTime).HasColumnName("AssignmentTime").IsRequired();
            builder.Property(a => a.AssignmentType).HasColumnName("AssignmentType").IsRequired();
            builder.Property(a => a.VideoUrl).HasColumnName("VideoUrl");

            builder.HasMany(a => a.File).WithOne().HasForeignKey(f => f.AssignmentId);
            

            builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
        }
    }


}
    
