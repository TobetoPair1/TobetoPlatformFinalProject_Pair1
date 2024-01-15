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
			builder.Property(a => a.LikeId).HasColumnName("LikeId").IsRequired();
			builder.Property(a => a.CategoryId).HasColumnName("CategoryId").IsRequired();
			builder.Property(a => a.CourseId).HasColumnName("CourseId").IsRequired();
			builder.Property(a => a.Title).HasColumnName("Title").IsRequired();            
            builder.Property(a => a.Name).HasColumnName("Name").IsRequired();            
            builder.Property(a => a.IsCompleted).HasColumnName("IsCompleted").IsRequired();
            builder.Property(a => a.Description).HasColumnName("Description").IsRequired();
            builder.Property(a => a.AssignmentTime).HasColumnName("AssignmentTime").IsRequired();
            builder.Property(a => a.AssignmentType).HasColumnName("AssignmentType").IsRequired();
            builder.Property(a => a.VideoUrl).HasColumnName("VideoUrl");

			builder.HasQueryFilter(a => !a.DeletedDate.HasValue);

			builder.HasMany(a => a.File);
            builder.HasOne(a=>a.Course).WithMany(a=>a.Assignments).HasForeignKey(a=>a.CourseId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a=>a.Category);
            builder.HasOne(a=>a.Like);         
           
        }
    }


}