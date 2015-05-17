using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            a += a++;
            Console.WriteLine("a = " + a);
            Console.ReadLine();

            int x = 20, y = 35;
            x = x++ + y++; // x = 55, y = 36
            y = ++x + ++y; // x = 56, x = 93
            Console.WriteLine("{0}{1}", x, y);
            Console.ReadLine();

            var s = "Hello World!";
            //s = 6; // Once a var has been assigned a type, it can no longer be changed
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}