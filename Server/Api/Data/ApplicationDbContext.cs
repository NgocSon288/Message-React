using Api.Configurations;
using Api.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
   public class ApplicationDbContext : IdentityDbContext<AppUser>
   {
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
      {

      }

      protected override void OnModelCreating(ModelBuilder builder)
      {
         base.OnModelCreating(builder);

         builder.ApplyConfigurationsFromAssembly(typeof(AppUserConfiguration).Assembly);
      }

      public DbSet<Chat> Chats { get; set; }
      public DbSet<Friend> Friends { get; set; }
      public DbSet<Message> Messages { get; set; }
      public DbSet<UserChat> UserChats { get; set; }
   }

}