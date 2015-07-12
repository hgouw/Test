using System;

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
    class D : I1, I2
    {
        public void A() // Implicit implementation
        {
            Console.WriteLine("D.A()");
        }
        void I1.A() // Explicit implementation
        {
            Console.WriteLine("D.I1.A()");
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
            Console.WriteLine("E.I1.A()");
        }
        void I2.A() // Explicit implementation
        {
            Console.WriteLine("E.I2.A()");
        }
    }
    class F : I1
    {
        void I1.A() // Explicit implementation
        {
            Console.WriteLine("F.I1.A()");
        }
    }
    class G : I1
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
            //f.A(); --- COMPILE ERROR
            i1 = (I1)f;
            //i2 = (I2)f; --- RUNTIME ERROR
            i1.A();
            Console.ReadLine();
        }
    }
}