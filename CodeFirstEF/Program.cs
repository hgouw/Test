using System;

namespace CodeFirstEF
{

    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new LogContext())
            {
                var log = new Log
                {
                    DateTime = DateTime.Now,
                    Message = "Error during logging",
                    Priority = Priorities.High
                };
                db.Logs.Add(log);
                db.SaveChanges();
            }

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
}