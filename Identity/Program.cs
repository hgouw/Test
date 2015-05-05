using System;

namespace Identity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetUserName());
            Console.ReadLine();
        }

        static string GetUserName()
        {
            return String.Format("{0}\\{1}", Environment.UserDomainName, Environment.UserName); ;
        }
    }
}