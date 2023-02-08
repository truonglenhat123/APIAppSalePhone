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

        [HttpGet("hello")]
        public async Task<IActionResult> Hello()
        {
            return Ok("Xin chao");
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
        [HttpGet("product/branch")]
        public IActionResult GetAllPrductsCategory()
        {
            var test = _context.Brands.Join(_context.Products, b => b.BrandId, p => p.BrandId, (b, p) => new { branch = b, product = p })
                .GroupBy(x => new { x.branch.BrandName }).ToList().Select(x => new { x.Key, product = x.Select(x => x.product).ToList() });

            var listasd = new List<Dictionary<string, List<ProductRes>>>();
            foreach (var x in test)
            {
                var temp = new Dictionary<string, List<ProductRes>>();
                temp.Add(x.Key.BrandName.ToString(), x.product?.Select(pro => new ProductRes
                { ProductName = pro.ProductName, NewPrice = pro.NewPrice, Image = pro.Image, Id = pro.Id, Descriptionshort = pro.Descriptionshort }).ToList());
                listasd.Add(temp);
            }
            return Ok(listasd);
        }
    }
}
