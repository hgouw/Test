using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
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

    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Staff : Employee
    {
        public string Department { get; set; }
    }
    class Manager : Employee
    {
        public int Staff { get; set; }
    }

    class Program
    {
        static void Modify(Employee employee)
        {
            //employee.Department = "xxx";
        }

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

            Staff staff = new Staff { Name = "Herman", Age = 53, Department = "IMT" };
            Manager manager = new Manager { Name = "Hamish", Age = 53, Staff = 6 };
            Modify(staff);
        }
    }
}
