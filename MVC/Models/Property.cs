using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Property
    {
        [Key, Column(Order = 1)]
        public string Street { get; set; }
        [Key, Column(Order = 2)]
        public string Number { get; set; }
        [Key, Column(Order = 3)]
        public string Suburb { get; set; }
        [Key, Column(Order = 4)]
        public string State { get; set; }
        [Key, Column(Order = 5)]
        public string Postcode { get; set; }
        public byte Type { get; set; }
        public decimal Price { get; set; }
        public DateTime SoldDate { get; set; }
    }
}