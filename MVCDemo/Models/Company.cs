using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    [Table("Companies")]
    public class Company
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
    }
}