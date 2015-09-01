using System;

namespace Type
{
    class Program
    {
        static void Main(string[] args)
        {
            short a = 0;
            short b = 0;
            try
            {
                while (true)
                {
                    unchecked
                    {
                        a++;
                    }
                    checked
                    {
                        b++;
                    }
                }
            }
            catch
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            
            sbyte signedbyte_ = -1; // 8 bytes
            short short_ = -12; // 16 bytes
            int int_ = -123; // 32 bytes
            long long_ = -1234; // 64 bytes

            byte byte_ = 1; // 8 bytes
            ushort unsignedshort_ = 12; // 16 bytes
            uint unsignedint_ = 123; // 32 bytes
            ulong unsignedlong_ = 1234; // 64 bytes

            float float_ = 12.34f; // Requires suffix
            double double_ = 12.34;
            decimal decimal_ = 12.34m; // Requires suffix

            Console.WriteLine(string.Format("byte = {0}", byte_));
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte_.GetType().Name);
            Console.WriteLine(byte_.GetType().FullName);
            Console.WriteLine(typeof(byte));
            Console.WriteLine(default(byte));

            // Narrowing must be done explicitly
            // Widening can be done implicitly
            int_ = (int)double_; // Cannot implicitly convert double to int (narrowing)
            int_ = (int)unsignedint_; // Cannot implicitly convert uint to int (narrowing)
            double_ = int_; // Implicit is allowed because it is widening (narrowing)
            decimal_ = signedbyte_; // Implicit is allowed because it is widening (narrowing)
            double_ = (double)decimal_; // Cannot implicitly convert decimal to double (narrowing)

            Console.WriteLine(int_.GetType().Name);
            Console.WriteLine(int_.GetType().FullName);
            Console.WriteLine(typeof(int));
            Console.WriteLine(float_.GetType().Name);
            Console.WriteLine(float_.GetType().FullName);
            Console.WriteLine(typeof(float));
            Console.WriteLine(double_.GetType().Name);
            Console.WriteLine(double_.GetType().FullName);
            Console.WriteLine(typeof(double));
            Console.WriteLine(decimal_.GetType().Name);
            Console.WriteLine(decimal_.GetType().FullName);
            Console.WriteLine(typeof(decimal));

            /*
            long val=30000;
            int i = (int)val;
            int j = static_cast<int>(val);
            int k = checked((int)val);
            */

            Console.ReadLine();
        }
    }
}