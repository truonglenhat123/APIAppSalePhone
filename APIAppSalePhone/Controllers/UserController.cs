using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIAppSalePhone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly FinalContext _context;
        public UserController(FinalContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetPrducts()
        {
            return Ok(await _context.Accounts.ToListAsync());
        }
    }
}
