using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer());
            customers.Add(new GoldCustomer());
            customers.Add(new SilverCustomer());
            //customers.Add(new Enquiry());
            foreach (Customer customer in customers)
            {
                customer.Add();
                Console.WriteLine(customer.Discount(1000));
            }
            Console.ReadLine();

            List<IDatabase> custs = new List<IDatabase>();
            custs.Add(new Customer());
            custs.Add(new GoldCustomer());
            custs.Add(new SilverCustomer());
            //custs.Add(new Enquiry());
            foreach (Customer cust in custs)
            {
                cust.Add();
                Console.WriteLine(cust.Discount(1000));
            }
            Console.ReadLine();
        }
    }

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