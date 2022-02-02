using Microsoft.EntityFrameworkCore;

namespace EFCoreRelationShipDemo2.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }
        public DbSet<User>Users { get; set; }
        public DbSet<FavCharacterOfUser> FavCharacterOfUsers { get; set; }
    }
}
