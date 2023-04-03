using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CartDemo.Models
{
    public class OrderDetail {

        [Key]
        public string OrderId { get; set; }
        [Required(ErrorMessage = "Required")]
        public DateTime DateOfOrder { get; set; }

        public string DeliveryDate { get; set; }

        [Required(ErrorMessage = "Required")]
        [ForeignKey("Product")]
        public string ProductId { get; set; }

       
        [Required(ErrorMessage = "Required")]
        [ForeignKey("Customer")]
        public string UserId { get; set; }
        public Customer Customer { get; set; }
        
        public Product Product { get; set; }
        //[Required(ErrorMessage = "Required")]
        //public string CustomerName{get; set;}


    }
}