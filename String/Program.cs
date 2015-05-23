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
            System.String s1 = "abc";
            System.String s2 = "def";
            s1 = s1 + s2;
            Console.WriteLine("s1 = {0}", s1);
            Console.ReadLine();

            // How to tokenize a string
            string accounts = "Cheque,EveryDay,HighInterest,Saving";
            string[] accountsArray = accounts.Split(',');
            foreach (var account in accountsArray)
                Console.WriteLine(account);
            Console.ReadLine();

            var str = "Line 1" + Environment.NewLine + "Line 2";
            Console.WriteLine(str);
            Console.ReadLine();

            str = string.Format("{0:000}", 1234);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}