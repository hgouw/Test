using System.Data.Entity;
using System.Data.Linq.Mapping;

namespace CodeFirstEF
{
    public class User
    {
        public int UserId { get; set; }
        [Column(Storage = "Name", DbType = "NVarChar(50) NOT NULL")]
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}