using Microsoft.AspNetCore.Identity;

namespace APIAppSalePhone.Data
{
    public class ApplicationUser
    {
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
