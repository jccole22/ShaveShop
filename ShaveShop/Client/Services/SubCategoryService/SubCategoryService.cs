using ShaveShop.Shared;
using System.Net.Http.Json;

namespace ShaveShop.Client.Services.SubCategoryService
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly HttpClient _http;
        public SubCategoryService(HttpClient http)
        {
            _http = http;
        }

        public List<SubCategory> SubCategories { get; set; } = new List<SubCategory>();

        public async Task GetSubCategories()
        {
            var respone = await _http.GetFromJsonAsync<ServiceResponse<List<SubCategory>>>("api/subcategory");
            if (respone != null && respone.Data != null)
            {
                SubCategories = respone.Data;
            }
        }
    }
}
