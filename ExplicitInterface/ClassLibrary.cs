using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
    interface I1
    {
        void A();
    }

    interface I2
    {
        void A();
    }

    class C : I1, I2
    {
        public void A() // Implicit implementation
        {
            Console.WriteLine("C.A()");
        }
    }

    class D: I1, I2
    {
        public void A() // Implicit implementation
        {
            Console.WriteLine("D.A()");
        }
        void I1.A() // Explicit implementation
        {
            Console.WriteLine("I1.A()");
        }
    }

    class E : I1, I2
    {
        public void A() // Implicit implementation
        {
            Console.WriteLine("E.A()");
        }
        void I1.A() // Explicit implementation
        {
            Console.WriteLine("I1.A()");
        }
        void I2.A() // Explicit implementation
        {
            Console.WriteLine("I2.A()");
        }
    }

    class F: I1
    {
        void I1.A() // Explicit implementation
        {
            Console.WriteLine("I1.A()");
        }
    }

    class G: I1
    {
        public void A()
        {
            throw new NotImplementedException();
        }

        void I1.A()
        {
            throw new NotImplementedException();
        }
    }
}