using System;
using System.Collections.Generic;

namespace Api.Entities
{
   public class UserChat
   {
      public int Id { get; set; }

      public Guid ChatId { get; set; }
      public Chat Chat { get; set; }

      public string AppUserId { get; set; }

      public AppUser AppUser { get; set; }

      public List<Message> Messages { get; set; }

      public UserChatType UserChatType { get; set; }
   }
}