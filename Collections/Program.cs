using System.Collections.Generic;

namespace Collections
{
    class User
    {
        public string Type { get; set; }
        public User(string type)
        {
            Type = type;
        }
    }
    class Program
    {
        static void Main(params string[] args)
        {
            Dictionary<string, User> users = new Dictionary<string, User>()
            {
                {"admin", new User("admin")},
                {"guest", new User("guest")}
            };
        }
    }
}