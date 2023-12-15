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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users").HasKey(u => u.Id);

            builder.Property(u=>u.Id).HasColumnName("Id").IsRequired();
            builder.Property(u=>u.Name).HasColumnName("Name").IsRequired();
            builder.Property(u=>u.LastName).HasColumnName("LastName").IsRequired();
            builder.Property(u=>u.Password).HasColumnName("Password").IsRequired();
            builder.Property(u=>u.Email).HasColumnName("Email").IsRequired();

            builder.HasQueryFilter(u => !u.DeletedDate.HasValue);
        }
    }
}
