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
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _context.Accounts.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<FinalContext>> GetUserById(int id)
        {
            var user = await _context.Accounts.FindAsync(id);
            if (user == null)
            {
                return BadRequest("User not found");
            }
            else
            {
                return Ok(user);
            }
        }
    }
}
