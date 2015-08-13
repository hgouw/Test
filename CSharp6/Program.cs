using System.Collections.Generic;
using static Helpers.Helper; // Using Static

namespace CSharp6
{
    class User
    {
        public Name Name { get; set; }
    }

    class Name
    {
        // Auto Property Initializers
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        // Expression-bodied Member
        // String Interpolation
        public override string ToString() => $"{FirstName} - {LastName}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict1 = new Dictionary<string, string>
            {
                { "Herman", "Akong" },
                { "Helen", "Hyunjung" }
            };

            // Dictionary Initializers
            Dictionary<string, string> dict2 = new Dictionary<string, string>
            {
                ["Herman"] = "Akong",
                ["Helen"] = "Hyunjung"
            };
        }


        void DisplayName(User user)
        {
            if (Okay())
            {
            }

            // Null Propagation Operator
            var LastName = user?.Name?.LastName ?? "lastname unknown";
        }
    }
}