using System;
using System.Threading;

namespace Event
{
    public class Program
    {
        static ManualResetEvent MyEvent;

        public static void Main()
        {
            MyEvent = new ManualResetEvent(true);

            ThreadStart MyThreadStart = new ThreadStart(Worker);
            Thread MyThread = new Thread(MyThreadStart);
            MyThread.Start();

            Console.ReadKey();
        }

        static void Worker()
        {
            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Working ...");
                MyEvent.WaitOne();
            }
        }
    }
}