using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CartDemo.Models
{
    public class Merchant { 

        [Key]
        public string MerchantId{get; set;}

        [Required(ErrorMessage = "Required")]
        public string MerchantName { get; set; }

        [Required(ErrorMessage = "Required")]

        
        public string SellingPrice { get; set; }

        [ForeignKey("Product")]
        public string ProductId { get; set; }

        
        //public string ProductName { get; set; }
    
    public Product Product { get; set; }


}
}