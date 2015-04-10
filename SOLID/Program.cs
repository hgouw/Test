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
}