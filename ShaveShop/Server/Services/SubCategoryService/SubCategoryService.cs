using ShaveShop.Server.Data;

namespace ShaveShop.Server.Services.SubCategoryService
{
    public class SubCategoryService : ISubCategoryService
    {
        public DataContext _context;

        public SubCategoryService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<SubCategory>>> GetSubCategoriesAsync()
        {
            var subcategories = await _context.SubCategories.ToListAsync();

            var response = new ServiceResponse<List<SubCategory>>()
            {
                Data = subcategories
            };
            return response;
        }
    }
}
