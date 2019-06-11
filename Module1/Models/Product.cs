using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace Module1.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; } 
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
    }
}
