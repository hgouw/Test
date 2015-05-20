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
    public class Base
    {
        public bool Flag { get; set; }

        public Base(bool flag)
        {
            Flag = flag;
        }
    }

    public class Base1 : Base
    {
        public Base1(bool flag) : base(flag) { }
    }

    public class Base2 : Base1
    {
        public Base2(bool flag) : base(flag) { }

        public virtual void Display()
        {
            Console.WriteLine("Flag = {0}", base.Flag);
        }
    }
    public class Base3 : Base2
    {
        public Base3(bool flag) : base(flag) { }
    }

    public class A
    {
        public virtual void ABC()
        {
            Console.WriteLine("A");
        }
    }
    public class B : A
    {
        public override void ABC()
        {
            Console.WriteLine("B");
        }
    }
    public class C : B
    {
        public new void ABC()
        {
            Console.WriteLine("C");
        }
    }
    class X
    {
        Y y1 = new Y();
        public X()
        {
            Console.Write("X");
        }
    }

    class Y
    {
        public Y()
        {
            Console.Write("Y");
        }
    }

    class Z : X
    {
        Y y2 = new Y();
        public Z()
        {
            Console.Write("Z");
        }
    }
}
