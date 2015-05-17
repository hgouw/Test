using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        [Flags]
        enum Direction
        {
            None = 0,
            Left = 1,
            Right = 2,
            Top = 4,
            Bottom = 8,
            Vertical = Left | Right,
            Horizontal = Top | Bottom,
            All = Vertical | Horizontal
        }

        static void Main(string[] args)
        {
            Direction direction = Direction.Top | Direction.Right;
            Console.WriteLine(direction.ToString());
            Console.WriteLine(Direction.Left.ToString());
            Console.WriteLine(Direction.Horizontal.ToString());
            Console.WriteLine(Direction.Vertical.ToString());
            Console.WriteLine(Direction.All.ToString());
            Console.ReadLine();
        }
    }
}