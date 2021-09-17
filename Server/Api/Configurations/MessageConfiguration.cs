using System;
using Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Configurations
{
   public class MessageConfiguration : IEntityTypeConfiguration<Message>
   {
      public void Configure(EntityTypeBuilder<Message> builder)
      {
         builder.ToTable("Messages");

         builder.HasKey(x => x.Id);

         builder.Property(x => x.Body)
            .IsRequired(true);

         builder.Property(x => x.CreatedDate)
            .HasDefaultValue(DateTime.Now);

         builder.HasOne(m => m.UserChat)
            .WithMany(u => u.Messages)
            .HasForeignKey(m => m.UserChatId);
      }
   }
}