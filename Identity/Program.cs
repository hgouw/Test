using System;

namespace Identity
{
    class Program
    {
        static string GetCurrentName()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }
        static string GetUserDomainNameGetUserName()
        {
            return String.Format("{0}\\{1}", Environment.UserDomainName, Environment.UserName);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("GetCurrentName = " + GetCurrentName());
            Console.WriteLine("GetUserDomainName = " + GetUserDomainNameGetUserName());
            Console.ReadLine();
        }
    }
}