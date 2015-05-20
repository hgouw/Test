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
}
