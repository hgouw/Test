﻿namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

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
}