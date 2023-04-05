using System.ComponentModel.DataAnnotations;
namespace CartDemo.Models
{
    public class Merchant
    {
        [Key]
        public string MerchantId { get; set; }

        [Required(ErrorMessage = "Name Required")]
        public string MerchantName { get; set; }

        [Required(ErrorMessage = "Contact Required")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string MerchantContact { get; set; }

        [Required(ErrorMessage = "Email Required")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'+/=?^_`{|}~-]+)@(?:[a-z0-9](?:[a-z0-9-][a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                            ErrorMessage = "Please enter a valid email address")]
        public string MerchantEmail { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password \"{0}\" must have {2} character", MinimumLength = 8)]
        [RegularExpression(@"^([a-zA-Z0-9@*#]{8,15})$", ErrorMessage = "Password must contain: Minimum 8 characters atleast 1 UpperCase Alphabet, 1 LowerCase Alphabet, 1 Number and 1 Special Character")]
        public string MerchantPassword { get; set; }

    }
}