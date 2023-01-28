using ShaveShop.Shared;

namespace ShaveShop.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories{ get; set; }
        Task GetCategories();
    }
}
