using System;

namespace Format
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 1024;
            Console.WriteLine(String.Format("{0:E}", (object)value));
            Console.WriteLine(String.Format("{0,00000000:X}", (object)value));
            Console.WriteLine(String.Format("{0:000}", (object)value));
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}