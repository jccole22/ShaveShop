using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShaveShop.Server.Data;

namespace ShaveShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;
        }



        [HttpGet]
        //return was Task<IActionResult> but needed to change to specific action result so api would know about product schema
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        //[HttpGet]
        //[Route("/api/string")]
        //public async Task<IActionResult> GetString()
        //{
        //    return Ok("Hello");
        //}

        [HttpGet]
        [Route("/testcall")]
        public async Task<IActionResult> GetTestCall()
        {
            return Ok("<h1>Tester tester</h1>");
        }
    }
}
