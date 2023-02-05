using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShaveShop.Server.Services.SubCategoryService;

namespace ShaveShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private readonly ISubCategoryService _subCategoryService;
        public SubCategoryController(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<SubCategory>>>> GetSubCategories()
        {
            var result = await _subCategoryService.GetSubCategoriesAsync();
            return Ok(result);
        }
    }
}
