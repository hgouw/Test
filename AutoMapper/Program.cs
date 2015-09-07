using System;

namespace AutoMapper
{
    public class Customer
    {
        public Company Company { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int NumberOfOrders { get; set; }
        public bool VIP { get; set; }
    }

    public class CustomerViewItem
    {
        public string CompanyName { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public int NumberOfOrders { get; set; }
        public string VIP { get; set; }
    }

    public class Company
    {
        public string Name { get; set; }
    }

    public class VIPResolver : ValueResolver<bool, string>
    {
        protected override string ResolveCore(bool source)
        {
            return source ? "Y" : "N";
        }
    }

    public class DateOfBirthResolver : ValueResolver<DateTime, string>
    {
        protected override string ResolveCore(DateTime source)
        {
            return source.ToLongDateString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            Mapper.CreateMap<Customer, CustomerViewItem>()
                .ForMember(cv => cv.FullName, m => m.MapFrom(s => s.FirstName + " " + s.LastName))
                .ForMember(cv => cv.VIP, m => m.ResolveUsing<VIPResolver>().FromMember(x => x.VIP))
                .ForMember(cv => cv.DateOfBirth, m => m.ResolveUsing<DateOfBirthResolver>().FromMember(x => x.DateOfBirth));

            program.Run();
        }

        private void Run()
        {
            Customer customer = GetCustomerFromDB();

            CustomerViewItem customerViewItem = Mapper.Map<Customer, CustomerViewItem>(customer);

            ShowCustomerInDataGrid(customerViewItem);
        }

        private Customer GetCustomerFromDB()
        {
            return new Customer()
            {
                DateOfBirth = new DateTime(1987, 11, 2),
                FirstName = "Andriy",
                LastName = "Buday",
                NumberOfOrders = 7,
                Company = new Company() { Name = "andriybuday.blogspot.com" },
                VIP = true
            };
        }

        private void ShowCustomerInDataGrid(CustomerViewItem customerViewItem) { }
    }
}