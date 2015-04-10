using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new UserContext())
            {
                Console.WriteLine("Enter name:");
                var name = Console.ReadLine();

                var user = new User { Name = name };
                db.Users.Add(user);
                db.SaveChanges();
            }

            using (var db = new UserContext())
            {
                var users = db.Users;
                foreach (var user in users)
                {
                    Console.WriteLine(user.Name);
                }
            }
            Console.WriteLine();
        }
    }

    public class User
    {
        public int UserId { get; set; }
        public string Name  { get; set; }
        public int Age { get; set; }
    }

    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}