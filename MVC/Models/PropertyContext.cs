using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class PropertyContext : DbContext
    {
        public DbSet<Property> Properties { get; set; }
    }
}