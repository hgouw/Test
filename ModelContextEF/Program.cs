using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ModelContextEF
{
    class IndustryGroup
    {
        [Key]
        public string Group { get; set; }
    }

    class Company
    {
        [Key]
        public string Code { get; set; }
        [ForeignKey("IndustryGroup")]
        public string Group { get; set; }

        public IndustryGroup IndustryGroup { get; set; }
    }

    class EndOfDay
    {
        [Key, Column(Order = 1), ForeignKey("Company")]
        public string Code { get; set; }
        [Key, Column(Order = 2)]
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Last { get; set; }
        public int Volume { get; set; }

        public Company Company { get; set; }
    }

    class Context : DbContext
    {
        public DbSet<IndustryGroup> IndustryGroups { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<EndOfDay> EndOfDays { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}