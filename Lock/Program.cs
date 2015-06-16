using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
