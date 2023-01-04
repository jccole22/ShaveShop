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
        //wrapped list in service response
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProduct()
        {
            var products = await _context.Products.ToListAsync();
            var response = new ServiceResponse<List<Product>>() {
                Data = products
            };
            //used to just return products directly
            return Ok(response);
        }

        //[HttpGet]
        //[Route("/api/string")]
        //public async Task<IActionResult> GetString()
        //{
        //    return Ok("Hello");
        //}
    }
}
