using ShaveShop.Shared;

namespace ShaveShop.Client.Services.SubCategoryService
{
    public interface ISubCategoryService
    {
        List<SubCategory> SubCategories { get; set; }
        Task GetSubCategories();
    }
}
