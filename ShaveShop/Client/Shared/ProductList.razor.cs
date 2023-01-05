using Microsoft.AspNetCore.Components;
using ShaveShop.Client.Services.ProductService;
using ShaveShop.Shared;

namespace ShaveShop.Client.Shared
{
    public class ProductListBase : ComponentBase
    {
        [Inject]
        protected IProductService ProductService { get; set; } 

        protected override async Task OnInitializedAsync()
        {
            await ProductService.GetProducts();
           
        }
    }
}
