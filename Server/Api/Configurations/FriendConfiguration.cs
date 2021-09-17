using System;
using Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Configurations
{
public class FriendConfiguration : IEntityTypeConfiguration<Friend>
   {
      public void Configure(EntityTypeBuilder<Friend> builder)
      {
         builder.ToTable("Friends");

         builder.HasKey(x=>x.Id);

         builder.Property(x=>x.CreatedDate)
            .HasDefaultValue(DateTime.Now);

         builder.Property(x=>x.UserFriendId)
            .IsRequired(true);

         builder.HasOne(f=>f.AppUser)
            .WithMany(u=>u.Friends)
            .HasForeignKey(f=>f.AppUserId);
      }
   }
}