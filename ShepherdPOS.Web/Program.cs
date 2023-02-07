using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShepherdPOS.Web;

//using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShepherdPOS.Web;
using ShepherdPOS.Web.Services;
using ShepherdPOS.Web.Services.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) }); Temporarily disable this statement blazor loader
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7282/") });
builder.Services.AddScoped<IProductService, ProductService>();

await builder.Build().RunAsync();

