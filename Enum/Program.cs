using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    class Program
    {
        enum Account
        {
            Cheque,
            EveryDay,
            HighInterest,
            Saving
        }

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
            foreach (var value in Enum.GetValues(typeof(Account)))
                Console.WriteLine("{0} - {1}", (Account)value, (int)value);
            Console.ReadLine();

            string chequeAccount = "Cheque";
            Account chequeAccountEnum = (Account)Enum.Parse(typeof(Account), chequeAccount);
            Console.WriteLine(chequeAccountEnum.ToString());
            Console.ReadLine();

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