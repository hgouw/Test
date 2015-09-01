using System;
using System.Security.Cryptography;
using System.Text;

namespace Cryptography
{
    class Program
    {
        static string CreateSHA1(string value)
        {
            SHA1 algorithm = SHA1.Create();
            byte[] data = algorithm.ComputeHash(Encoding.UTF8.GetBytes(value));
            string sha1 = "";
            foreach (var datum in data)
            {
                sha1 += datum.ToString("x2").ToUpperInvariant();
            }
            return sha1;
        }

        static void Main(string[] args)
        {
            var passwords = new string[] { "J3sus", "M05e5", "D@v1d", "@6r@h@m" };
            foreach (string password in passwords)
            {
                Console.WriteLine(String.Format("{0} - {1}", password, CreateSHA1(password)));
            }
            Console.ReadLine();
        }
    }
}