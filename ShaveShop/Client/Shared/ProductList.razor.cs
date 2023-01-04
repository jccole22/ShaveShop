using Microsoft.AspNetCore.Components;
using ShaveShop.Shared;
using System.Net.Http.Json;

namespace ShaveShop.Client.Shared
{
    public class ProductListBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }

        protected static List<Product> Products = new List<Product>();

        protected override async Task OnInitializedAsync()
        {
            var result = await Http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }
        }
    }
}
