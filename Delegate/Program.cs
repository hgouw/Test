using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        public delegate void WriteDelegate(string msg);

        static void Main(string[] args)
        {
            Log log = new Log();
            WriteDelegate writeDelegate = new WriteDelegate(log.Write);
            writeDelegate("Hello World!");
            Console.ReadLine();
        }
    }

    public class Log
    {
        public void Write(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}