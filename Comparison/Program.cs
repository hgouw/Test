using System;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            object o1 = "Hello World!";
            object o2 = o1;
            object o3 = new string("Hello World!".ToCharArray());

            // == compares object references
            // Equals() compares object contents
            // String datatype always does content comparison

            Console.WriteLine(o1 == o2);
            Console.WriteLine(o1.Equals(o2));
            Console.WriteLine(o1 == o3);
            Console.WriteLine(o1.Equals(o3));
            Console.ReadLine();
        }
    }
}