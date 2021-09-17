using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Api.Entities
{
   public class AppUser : IdentityUser
   {
      public string Name { get; set; }

      public List<UserChat> UserChats { get; set; }
      public List<Friend> Friends { get; set; }
      public DateTime CreatedDate { get; set; }
   }
}