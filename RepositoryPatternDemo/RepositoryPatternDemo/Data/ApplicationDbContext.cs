using Microsoft.EntityFrameworkCore;
using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
  
        public DbSet<Users> users { get; set; }
    }
}
