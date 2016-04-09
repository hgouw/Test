using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ASX
{
    public class Program
    {
        static void Main()
        {
            using (var context = new ASXContext())
            {
                var companies = context.Companies.ToList();
                var endOfDays = companies.First(c => c.Code == "MPL").EndOfDays;
            }
        }
    }

    public class ASXContext : DbContext
    {
        public DbSet<IndustryGroup> IndustryGroups { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<EndOfDay> EndOfDays { get; set; }
        public DbSet<WatchList> WatchLists { get; set; }
    }

    public class IndustryGroup
    {
        [Key]
        public string Group { get; set; }
        public virtual List<Company> Companies { get; set; }
    }

    public class Company
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public virtual List<EndOfDay> EndOfDays { get; set; }
    }

    public class EndOfDay
    {
        [Key, Column(Order = 1), ForeignKey("Company")]
        public string Code { get; set; }
        [Key, Column(Order = 2)]
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public int Volume { get; set; }
        public virtual Company Company { get; set; }
    }

    public class WatchList
    {
        [Key]
        public string Code { get; set; }
        public virtual Company Company { get; set; }
    }
}