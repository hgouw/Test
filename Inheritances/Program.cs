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
            var base3 = new Base3(true);
            base3.Display();
            Console.WriteLine("Flag = {0}", base3.Flag);
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
