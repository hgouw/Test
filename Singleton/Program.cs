using System;

namespace Singleton
{
    public class Singleton1
    {
        private static Singleton1 instance;

        private Singleton1() { }

        public static Singleton1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton1();
                }
                return instance;
            }
        }
    }

    public sealed class Singleton2
    {
        private static readonly Singleton2 instance = new Singleton2();

        private Singleton2() { }

        public static Singleton2 Instance
        {
            get
            {
                return instance;
            }
        }
    }

    /// <summary>
    /// Multithreaded Singleton
    /// </summary>
    public sealed class Singleton3
    {
        private static volatile Singleton3 instance;
        private static object syncRoot = new Object();

        private Singleton3() { }

        public static Singleton3 Instance
        {
            get
            {
                if (instance == null)
                {
                    // DO NOT USE lock (this), lock (typeof (MyType)), lock ("myLock")
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Singleton3();
                    }
                }

                return instance;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}