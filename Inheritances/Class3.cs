using System;

namespace Inheritance
{
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