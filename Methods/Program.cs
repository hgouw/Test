using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        public static void Display(int? num)
        {
            Console.WriteLine(num);
        }
        public static void Display(string num)
        {
            Console.WriteLine(num);
        }

        /*
        static void Func(int a, ref int b, out int c)
        {
            a = a * 2;
            b = b * 2;
            c = c * 2; // Compile error - use of unassigned out parameter
        }
        */

        static void Main(string[] args)
        {
            Display(1);
            Display("1");
            //Display(null);  // Compile error (ambiguous call) - int? and string can both have null values.
            Console.ReadLine();
        }
    }
}