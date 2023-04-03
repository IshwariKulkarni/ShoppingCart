using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CartDemo.Models
{
    public class TransactionDetail
    {
        [Key]
        public int TransactionId { get; set; }

        [Required]
        public string TransactionType { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }  

        public float Amount { get; set; }

        [ForeignKey("Product")]
        public string ProductId { get; set; }

        [ForeignKey("Customer")]
        public string UserId { get; set; }

        //navigation property

        public virtual Product Product { get; set; }

        public virtual Customer Customer { get; set; }
    }
}