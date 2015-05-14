using System;

namespace Identity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GetCurrentName = " + GetCurrentName());
            Console.WriteLine("GetUserName = " + GetUserDomainNameGetUserName());
            Console.ReadLine();
        }

        static string GetCurrentName()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }

        static string GetUserDomainNameGetUserName()
        {
            return String.Format("{0}\\{1}", Environment.UserDomainName, Environment.UserName);
        }
    }
}