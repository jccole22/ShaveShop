using Microsoft.AspNetCore.Components;
using ShaveShop.Client.Services.ProductService;
using ShaveShop.Shared;


namespace ShaveShop.Client.Shared
{
    public class ProductListBase : ComponentBase, IDisposable
    {
        [Inject]
        protected IProductService ProductService { get; set; }
        

        protected override void OnInitialized()
        {
            ProductService.ProductsChanged += StateHasChanged;
           
        }

        public void Dispose()
        {
            ProductService.ProductsChanged -= StateHasChanged;
        }
    }
}
