using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            I1 i1 = (I1)c;
            I2 i2 = (I2)c;
            i1.A();
            i2.A();
            c.A();
            Console.ReadLine();

            D d = new D();
            i1 = (I1)d;
            i2 = (I2)d;
            i1.A();
            i2.A();
            d.A();
            Console.ReadLine();

            E e = new E();
            i1 = (I1)e;
            i2 = (I2)e;
            i1.A();
            i2.A();
            e.A();
            Console.ReadLine();

            F f = new F();
            i1 = (I1)f;
            //i2 = (I2)f; --- RUNTIME ERROR
            i1.A();
            i2.A();
            //f.A(); --- COMPILE ERROR
            Console.ReadLine();
        }
    }
}