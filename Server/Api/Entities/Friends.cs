using System;
namespace Api.Entities
{
   public class Friend
   {
      public int Id { get; set; }

      public string UserFriendId { get; set; }

      public string AppUserId { get; set; }

      public AppUser AppUser { get; set; }

      public DateTime CreatedDate { get; set; }
   }
}