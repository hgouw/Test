using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    [Table("IndustryGroups")]
    public class IndustryGroup
    {
        [Key]
        public string Group { get; set; }
        public List<Company> Companies { get; set; }
    }
}