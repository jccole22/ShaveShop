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
        protected string message = string.Empty;
        [Parameter]
        public int Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            message = "Loading product...";

            var response = await ProductService.GetProduct(Id);
            if (!response.Success)
            {
                message = response.Message;
            }
            else
            {
                product = response.Data;
            }
        }
    }
}
