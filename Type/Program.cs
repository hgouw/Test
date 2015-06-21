using System;

namespace Type
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte signedbyte_ = -1;
            short short_ = -12;
            int int_ = -123;
            long long_ = -1234;

            byte byte_ = 1;
            ushort unsignedshort_ = 12;
            uint unsignedint_ = 123;
            ulong unsignedlong_ = 1234;

            float float_ = 12.34f; // Requires suffix
            double double_ = 12.34;
            decimal decimal_ = 12.34m; // Requires suffix

            int_ = (int)double_; // Cannot implicitly convert double to int
            int_ = (int)unsignedint_; // Cannot implicitly convert uint to int
            double_ = int_;
            decimal_ = signedbyte_;
            double_ = (double)decimal_; // Cannot implicitly convert decimal to double

            Console.WriteLine(int_.GetType().Name);
            Console.WriteLine(int_.GetType().FullName);
            Console.WriteLine(typeof(int));
            Console.WriteLine(float_.GetType().Name);
            Console.WriteLine(float_.GetType().FullName);
            Console.WriteLine(typeof(float));

            Console.ReadLine();
        }
    }
}