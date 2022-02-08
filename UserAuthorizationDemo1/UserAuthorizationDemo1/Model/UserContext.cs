using Microsoft.EntityFrameworkCore;

namespace UserAuthorizationDemo1.Model
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {


        }
        public DbSet<UserRecord> userRecords { get; set; }
    }
}
