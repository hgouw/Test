using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var base1 = new Base1(true);
            base1.Display();
            Console.WriteLine("Flag = {0}", base1.Flag);
            Console.ReadLine();

            A a = new C();
            B b = new C();
            C c = new C();
            a.ABC();
            b.ABC();
            c.ABC();
            Console.ReadLine();

            new Z();
            Console.ReadLine();
        }
    }
}
