using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CartDemo.Models
{
    public class Customer
    {
        [Key]
        public string UserId { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required")]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Required")]
        public int ContactNo { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Password { get; set; }

    }
}