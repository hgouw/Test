using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritances
{
    public class Base1 : Base2
    {
        public Base1(bool flag) : base(flag) { }
    }

    public class Base2 : Base3
    {
        public Base2(bool flag) : base(flag) {}

        public virtual void Display()
        {
            Console.WriteLine("Flag = {0}", base.Flag);
        }
    }

    public class Base3 : Base4
    {
        public Base3(bool flag) : base(flag) {}
    }

    public class Base4
    {
        public bool Flag { get; set; }

        public Base4(bool flag)
        {
            Flag = flag;
        }
    }
}
