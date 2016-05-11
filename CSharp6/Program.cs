using System;
using System.Collections.Generic;
using static System.Console;
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
        public override string ToString() => $"FirstName = {FirstName} - LastName = {LastName}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            // nameof
            WriteLine(nameof(User));
            WriteLine(nameof(User.Name));
            WriteLine(nameof(Name.FirstName));
            var name = new Name { FirstName = "Herman", LastName = "Gouw" };
            WriteLine(name.ToString());
            ReadLine();

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
            if (Okay()) {}

            // Null Conditional Operator
            var LastName = user?.Name?.LastName ?? "lastname unknown";
        }
    }
}