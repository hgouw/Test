using System;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception1();
            Console.ReadLine();
        }

        static void Exception1()
        {
            try
            {
                try
                {
                    int x = 0;
                    int y = 6 / x;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Caught inner Divide by Zero Exception");
                    throw;
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("Caught inner General Exception - " + ex.Message);
                    throw;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Caught outer Divide by Zero Exception");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Caught outer General Exception - " + ex.Message);
            }
        }
    }
}