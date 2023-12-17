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
    public class CertificateConfiguration : IEntityTypeConfiguration<Certificate>
    {
        public void Configure(EntityTypeBuilder<Certificate> builder)
        {
            builder.ToTable("Certificates").HasKey(c=>c.Id);

            builder.Property(c=>c.Name).HasColumnName("Name").IsRequired();
            builder.Property(c=>c.UserId).HasColumnName("UserId").IsRequired();
            builder.Property(c=>c.FilePath).HasColumnName("FilePath").IsRequired();
            builder.Property(c=>c.FileType).HasColumnName("FileType").IsRequired();

            builder.HasQueryFilter(c => !c.DeletedDate.HasValue);

            builder.HasOne(pi => pi.User);

        }
    }
}
