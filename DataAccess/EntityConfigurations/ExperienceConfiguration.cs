using Core.Entities;
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
    public class ExperienceConfiguration:IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
            builder.ToTable("Experiences").HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("Id").IsRequired();
            builder.Property(e=>e.UserId).HasColumnName("UserId").IsRequired();
            builder.Property(e => e.OrganizationName).HasColumnName("OrganizationName").IsRequired();
            builder.Property(e=>e.Position).HasColumnName("Position").IsRequired();
            builder.Property(e=>e.Sector).HasColumnName("Sector").IsRequired();
            builder.Property(e=>e.City).HasColumnName("City").IsRequired(false);
            //builder.Property(e => e.StartOfDate).HasColumnName("StartOfDate").IsRequired();
            //builder.Property(e => e.EndOfDate).HasColumnName("EndOfDate").IsRequired();
            builder.Property(e=>e.Description).HasColumnName("Description").IsRequired(false);


            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);

            builder.HasOne(e => e.User);
        }
    }
}
