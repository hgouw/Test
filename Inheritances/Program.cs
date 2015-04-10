using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritances
{
    class Program
    {
        static void Main(string[] args)
        {
            var base1 = new Base1(true);
            base1.Display();
            Console.WriteLine("Flag = {0}", base1.Flag);
            Console.ReadLine();
        }
    }
}
