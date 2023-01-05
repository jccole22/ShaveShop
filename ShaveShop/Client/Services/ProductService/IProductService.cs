using ShaveShop.Shared;

namespace ShaveShop.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        Task GetProducts();
    }
}
