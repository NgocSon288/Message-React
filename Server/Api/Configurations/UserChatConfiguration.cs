using System;
using Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Configurations
{
public class UserChatConfiguration : IEntityTypeConfiguration<UserChat>
   {
      public void Configure(EntityTypeBuilder<UserChat> builder)
      {
         builder.ToTable("UserChats");

         builder.HasKey(x=>x.Id);

         builder.Property(x=>x.UserChatType)
            .IsRequired(true);

         builder.HasOne(u=>u.Chat)
            .WithMany(c=>c.UserChats)
            .HasForeignKey(u=>u.ChatId);

         builder.HasOne(au => au.AppUser)
            .WithMany(u => u.UserChats)
            .HasForeignKey(au => au.AppUserId);
      }
   }
}