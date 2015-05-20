using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Program
    {
        static int maxIntValue = 2147483647;

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

            Console.WriteLine("CHECKED output value is: {0}", CheckedMethod());
            Console.WriteLine("UNCHECKED output value is: {0}", UncheckedMethod());
            Console.ReadLine();
        }

        static int CheckedMethod()
        {
            int z = 0;
            try
            {
                z = checked(maxIntValue + 10);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("CHECKED and CAUGHT:  " + e.ToString());
            }
            return z;
        }

        static int UncheckedMethod()
        {
            int z = 0;
            try
            {
                z = maxIntValue + 10;
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("UNCHECKED and CAUGHT:  " + e.ToString());
            }
            return z;
        }
    }
}