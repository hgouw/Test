﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchemaFirstEF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ASXDBContext : DbContext
    {
        public ASXDBContext()
            : base("name=ASXDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<EndOfDay> EndOfDays { get; set; }
        public virtual DbSet<IndustryGroup> IndustryGroups { get; set; }
        public virtual DbSet<WatchList> WatchLists { get; set; }
    }
}