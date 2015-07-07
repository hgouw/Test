using System;

namespace Delegate
{
    class Program
    {
        public delegate void WriteDelegate(string msg);

        public static class Log
        {
            public static void Write(string msg)
            {
                Console.WriteLine(msg);
            }
        }

        static void Main(string[] args)
        {
            //Log log = new Log();
            //WriteDelegate writeDelegate = new WriteDelegate(log.Write);
            WriteDelegate writeDelegate = new WriteDelegate(Log.Write);
            writeDelegate("Hello World!");
            Console.ReadLine();
        }
    }
}