using ShaveShop.Shared;
using System.Net.Http.Json;

namespace ShaveShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public event Action ProductsChanged;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public List<Product> Products { get; set; } = new List<Product>();
        public Product Product { get; set; } = new Product();


        public async Task GetProducts(string? categoryUrl = null, string? subcategoryUrl = null)
        {
            ServiceResponse<List<Product>>? result = null;
            if (categoryUrl == null && subcategoryUrl == null)
            {
                result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
            } 
            else if (categoryUrl != null && subcategoryUrl == null)
            {
                result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");
            }
            else
            {
                result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/subcategory/{subcategoryUrl}");
            }

            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }

            ProductsChanged.Invoke();
        }

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            return result;
        }
    }
}
