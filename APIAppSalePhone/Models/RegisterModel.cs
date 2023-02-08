using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIAppSalePhone.Models
{
    [Table("Account")]
    public class RegisterModel
    {
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Phone { get; set; } = null!;
        [Required, EmailAddress]
        public string Email { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
        //[Required]
        //public string ConfirmPassword { get; set; } = null!;
    }
}
