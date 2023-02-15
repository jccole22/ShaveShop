namespace ShaveShop.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
        Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl);
        Task<ServiceResponse<List<Product>>> GetProductsBySubCategoryAsync(string subcategoryUrl);
    }
}
