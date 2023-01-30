using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIAppSalePhone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly FinalContext _context;
        public ProductController(FinalContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPrducts()
        {
            return Ok(await _context.Products.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<FinalContext>> GetProductById(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return BadRequest("product not found");
            }
            else
            {
                return Ok(product);
            }
        }
    }
}
