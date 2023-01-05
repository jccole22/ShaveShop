using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShaveShop.Server.Data;
using ShaveShop.Server.Services.ProductService;

namespace ShaveShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }



        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            //moved all logic inside the ProductService class
            var result = await _productService.GetProductstAsync();
            return Ok(result);
        }

        //[HttpGet]
        //[Route("/api/string")]
        //public async Task<IActionResult> GetString()
        //{
        //    return Ok("Hello");
        //}
    }
}
