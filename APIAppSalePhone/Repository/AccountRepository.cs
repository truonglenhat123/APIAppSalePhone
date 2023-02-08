using APIAppSalePhone.Data;
using APIAppSalePhone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Web.Helpers;

namespace APIAppSalePhone.Repository
{
    public class AccountRepository : IAccountRepository
    {
        //private readonly UserManager<ApplicationUser> userManager;
        //private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IConfiguration configuration;
        private readonly FinalContext _context;
        public AccountRepository( IConfiguration configuration, FinalContext context)
        {
            //this.userManager = userManager;
            //this.signInManager = signInManager;
            this.configuration = configuration;
            _context = context;
    }
        public  string SignIn(LoginModel model)
        {
            model.Password = Crypto.Hash(model.Password);
            var result = _context.Accounts.FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);
            if (result==null)
            {
                return null;
            }
            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Email,model.Email),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
            };
            var authenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));
            var token = new JwtSecurityToken(
                issuer: configuration["JWT:ValidIssuer"],
                audience: configuration["JWT:ValidAudience"],
                expires:DateTime.Now.AddMinutes(5),
                claims:authClaims,
                signingCredentials:new SigningCredentials(authenKey,SecurityAlgorithms.HmacSha256Signature)

                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public  bool SignUp(RegisterModel model)
        {
            var checkEmail = _context.Accounts.Any(m => m.Email == model.Email);
            if (checkEmail)
            {
                
                return false;
            }
            Account account = new Account();
          
            account.Role = 1;
            account.Status = "1";
            account.Role = 1;
            account.Email = model.Email;
            account.CreateBy = model.Email;
            account.UpdateBy = model.Email;
            account.Name = model.Name;
            account.Phone = model.Phone;
            account.UpdateAt = DateTime.Now;
            account.Password = Crypto.Hash(model.Password);
            account.CreateAt = DateTime.Now;
            _context.Accounts.Add(account);
            _context.SaveChanges();
            return true;
        }
    }
}
