using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace maithithuy_GK.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string NameProduct { get; set; }
        [Required]
        public double UnitPrice { get; set; }
        [Required]
        public string ImageProduct { get; set; }

    }
}