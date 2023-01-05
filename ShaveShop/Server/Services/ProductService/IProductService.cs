namespace ShaveShop.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductstAsync();
    }
}
