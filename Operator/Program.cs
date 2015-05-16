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
        }
    }
}