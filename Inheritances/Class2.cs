using System;

namespace Inheritance
{
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
}