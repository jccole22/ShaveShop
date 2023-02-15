using ShaveShop.Shared;

namespace ShaveShop.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;
        List<Product> Products { get; set; }
        Task GetProducts(string? categoryUrl = null, string? subcategoryUrl = null);
        Task<ServiceResponse<Product>> GetProduct(int productId);
    }
}
