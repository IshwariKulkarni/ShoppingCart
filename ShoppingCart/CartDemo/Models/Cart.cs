using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CartDemo.Models
{
    public class Cart
    {
        public string ProductName { get; set; }
        [Key]
        public string CartId { get; set; }  
        public string ProductQuantity { get; set; }
        public string ProductPrice { get; set; }
        public string ProductId { get; set; }
    }
}