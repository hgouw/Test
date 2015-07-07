using System;

namespace Lock
{
    class Program
    {
        private static object syncRoot = new Object();

        static void Main(string[] args)
        {
            lock (syncRoot)
            {
                lock (syncRoot)
                {
                    Console.Write("Hello ");
                }
                Console.WriteLine("World!");
            }
            Console.ReadLine();
        }
    }
}