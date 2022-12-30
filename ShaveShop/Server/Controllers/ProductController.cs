using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShaveShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Title = "RAM HORN 5/8 BLADE STRAIGHT RAZOR",
                Description = "The handcrafted Ram's Horn Straight Razor by Thiers Issard of France, offers over 100 years of craftsmanship expertise. The high quality carbon steel blade delivers a clean, close cut. While the rustic Ram's Horn handle offers a distinctive Old World style. The Thiers Issard Ram's Horn Straight Razor is an excellent blade for beginners and experts alike.",
                ImageUrl = "https://cdn11.bigcommerce.com/s-iq1w68t3mw/images/stencil/320w/products/563/896/00670535711476__83634.1630010155.png?c=1",
                Price = 335.00m
            },
            new Product
            {
                Id = 2,
                Title = "Bovine Horn 5/8 Blade Straight Razor",
                Description = "The Horn Straight Razor handcrafted by Thiers Issard of France offers over 100 years of craftsmanship expertise. The high quality carbon steel blade delivers a clean, close cut. While the Bovine* Horn handle offers a one of a kind luxury scale. The Thiers Issard Horn Straight Razor is an excellent blade for beginners and experts alike.",
                ImageUrl = "https://cdn11.bigcommerce.com/s-iq1w68t3mw/images/stencil/320w/products/567/1620/str_bovine_horn_5_8_blade__77767.1630010130.jpg?c=1",
                Price = 320.99m
            },
            new Product
            {
                Id = 3,
                Title = "Stainless Steel 5/8 Blade Straight Razor",
                Description = "The handcrafted straight razor by Thiers Issard of France offers over 100 years of craftsmanship expertise. The high quality carbon steel, hollow ground blade is matched with a sleek stainless steel handle for a monotone metallic appearance. Due to the heavier weighting of the stainless steel handle, this straight razor best suited for a seasoned straight razor shaver.",
                ImageUrl = "https://cdn11.bigcommerce.com/s-iq1w68t3mw/images/stencil/320w/products/566/1626/str_stainless_steel_5_8_blade__20887.1630010428.jpg?c=1",
                Price = 195.99m
            }
        };

        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            return Ok(Products);
        }

        [HttpGet]
        [Route("/api/string")]
        public async Task<IActionResult> GetString()
        {
            return Ok("Hello");
        }
    }
}
