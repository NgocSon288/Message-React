using System;
using Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Configurations
{
public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
   {
      public void Configure(EntityTypeBuilder<AppUser> builder)
      {
         builder.ToTable("AppUsers");

         builder.HasKey(x=>x.Id);

         builder.Property(x=>x.Name)
            .IsRequired(true)
            .HasMaxLength(200);

         builder.Property(x=>x.CreatedDate)
            .HasDefaultValue(DateTime.Now);
      }
   }
}