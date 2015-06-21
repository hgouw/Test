using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abc";
            string s2 = "def";
            s1 = s1 + s2;
            Console.WriteLine("s1 = {0}", s1);
            Console.ReadLine();

            // How to tokenize a string
            string accounts = "Cheque,EveryDay,HighInterest,Saving";
            string[] accountsArray = accounts.Split(',');
            foreach (var account in accountsArray)
                Console.WriteLine(account);
            Console.ReadLine();

            var s = "Line 1" + Environment.NewLine + "Line 2";
            Console.WriteLine(s);
            Console.ReadLine();

            s = string.Format("{0:000}", 1234);
            Console.WriteLine(s);
            Console.ReadLine();

            s1 = "abc";
            s2 = "def";
            s = s1 + s2;
            Console.WriteLine(s);
            //s1 = s1 * s2; // No such operator
            //s1.Append(s2); // No such method
            //s1.Concat(s2); // Concat is a static method
            s = System.String.Concat(s1, s2);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}