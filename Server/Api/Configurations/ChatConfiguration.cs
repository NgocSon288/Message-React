using System;
using Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Configurations
{
public class ChatConfiguration : IEntityTypeConfiguration<Chat>
   {
      public void Configure(EntityTypeBuilder<Chat> builder)
      {
         builder.ToTable("Chats");

         builder.HasKey(x=>x.Id);

         builder.Property(x=>x.RoomName)
            .IsRequired(true)
            .HasMaxLength(200);

         builder.Property(x=>x.CreatedDate)
            .HasDefaultValue(DateTime.Now);
      }
   }
}