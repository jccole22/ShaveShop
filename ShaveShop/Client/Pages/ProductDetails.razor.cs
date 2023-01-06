using Microsoft.AspNetCore.Components;
using ShaveShop.Client.Services.ProductService;
using ShaveShop.Shared;

namespace ShaveShop.Client.Pages
{
    public class ProductDetailsBase : ComponentBase
    {
        [Inject]
        protected IProductService ProductService { get; set; }

        protected Product? product = null;
        [Parameter]
        public int Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            product = ProductService.Products.Find(p => p.Id == Id);
        }
    }
}
