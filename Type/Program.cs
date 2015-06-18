using System;

namespace Type
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 6;
            var f = 6.10;

            Console.WriteLine(i.GetType().Name);
            Console.WriteLine(i.GetType().FullName);
            Console.WriteLine(typeof(int));
            Console.WriteLine(f.GetType().Name);
            Console.WriteLine(f.GetType().FullName);
            Console.WriteLine(typeof(double));

            Console.ReadLine();
        }
    }
}