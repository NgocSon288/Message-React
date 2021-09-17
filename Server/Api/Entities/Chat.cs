using System;
using System.Collections.Generic;

namespace Api.Entities
{
   public class Chat
   {
      public Guid Id { get; set; }
      public string RoomName { get; set; }
      public DateTime CreatedDate { get; set; }
      public List<UserChat> UserChats { get; set; }
   }
}