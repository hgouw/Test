using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public interface IDiscount
    {
        double Discount(double amount);
    }

    public interface IDatabase
    {
        void Add();
    }

    public class Customer : IDiscount, IDatabase
    {
        public virtual double Discount(double amount)
        {
            return amount;
        }

        public virtual void Add()
        {
            Console.WriteLine("Add Customer");
        }
    }

    public class GoldCustomer : Customer
    {
        public override double Discount(double amount)
        {
            return base.Discount(amount) - 100;
        }

        public override void Add()
        {
            Console.WriteLine("Add Gold Customer");
        }
    }

    public class SilverCustomer : GoldCustomer
    {
        public override double Discount(double amount)
        {
            return base.Discount(amount) - 50;
        }

        public override void Add()
        {
            Console.WriteLine("Add Silver Customer");
        }
    }

    public class Enquiry : IDiscount
    {
        public virtual double Discount(double amount)
        {
            return amount - 5;
        }
    }
}