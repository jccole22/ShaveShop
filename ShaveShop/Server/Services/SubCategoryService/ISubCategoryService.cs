namespace ShaveShop.Server.Services.SubCategoryService
{
    public interface ISubCategoryService
    {
        Task<ServiceResponse<List<SubCategory>>> GetSubCategoriesAsync();
    }
}
