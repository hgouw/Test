using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CodeFirstEF
{
    public enum Priorities
    {
        High = 0,
        Medium = 5,
        Low = 10
    }

    public class Log
    {
        [Key, Column(Order = 1)]
        public DateTime DateTime { get; set; }
        public string Message { get; set; }
        [Key, Column(Order = 2)]
        public Priorities Priority { get; set; }
    }

    public class LogContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }
    }
}