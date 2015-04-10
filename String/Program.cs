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
            var str = "Line 1" + Environment.NewLine + "Line 2";
            Console.WriteLine(str);
            Console.ReadLine();

            str = string.Format("{0:000}", 1234);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}