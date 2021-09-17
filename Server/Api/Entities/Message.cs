using System;

namespace Api.Entities
{
   public class Message
   {
      public int Id { get; set; }
      public string Body { get; set; }
      public int UserChatId { get; set; }
      public UserChat UserChat { get; set; }
      public DateTime CreatedDate { get; set; }
   }
}