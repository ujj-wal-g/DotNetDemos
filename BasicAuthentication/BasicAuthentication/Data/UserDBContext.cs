using Microsoft.EntityFrameworkCore;

namespace BasicAuthentication.Data
{
    public class UserDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-5NEPIAJ;Database=UsersAuthDB;Trusted_Connection=True;");
        }
         public DbSet<UserAuthentication> userAuthentications { get; set; }
    }
} 
