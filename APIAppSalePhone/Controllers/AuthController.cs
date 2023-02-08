using APIAppSalePhone.Models;
using APIAppSalePhone.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIAppSalePhone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        //private readonly Account _account;

        private IAccountRepository accountRepository;

        public AuthController(IAccountRepository repo)
        {
            accountRepository = repo;
        }
        [HttpPost("SignUp")]
        public  IActionResult SignUp(RegisterModel signUpModel)
        {
            var result = accountRepository.SignUp(signUpModel);
            if (!result)
            {
                return BadRequest("Email existed!");
            }
            return Ok("Register completed");
        }

        [HttpPost("SignIn")]
        public  IActionResult SignIn(LoginModel loginModel)
        {
            var result =  accountRepository.SignIn(loginModel);
            if(string.IsNullOrEmpty(result))
            {
                return BadRequest("UserName or Password incorrect");
            }
            return Ok(result);
        }

    }
}
