using Microsoft.AspNetCore.Components;
using ShepherdPOS.Models.Dtos;

namespace ShepherdPOS.Web.Pages
{
    public class DisplayProductsBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }

    }
}

