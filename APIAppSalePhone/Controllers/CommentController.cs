using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIAppSalePhone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly FinalContext _context;
        public CommentController(FinalContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllComments()
        {
            return Ok(await _context.Feedbacks.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<FinalContext>> GetCommentById(int id)
        {
            var comment = await _context.Feedbacks.FindAsync(id);
            if (comment == null)
            {
                return BadRequest("comment not found");
            }
            else
            {
                return Ok(comment);
            }
        }
    }
}
