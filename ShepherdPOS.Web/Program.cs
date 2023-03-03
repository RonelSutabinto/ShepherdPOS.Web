using Blazored.Modal;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShepherdPOS.Web;

using Blazored.LocalStorage;
using MudBlazor.Services;
using ShepherdPOS.Web.Shared;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) }); Temporarily disable this statement blazor loader 7282
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7282/") });
//builder.Services.AddScoped<IProductService, ProductService>();
//builder.Services.AddScoped<IPosCartService, PosCartService>();

builder.Services.AddHttpClient("ShepherdPOS.Api", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("ShepherdPOS.Api"));


builder.Services.AddBlazoredLocalStorage();
builder.Services.AddMudServices();

//builder.Services.AddScoped<IManageProductsLocalStorageService, ManageProductsLocalStorageService>();
//builder.Services.AddScoped<IManageCartItemsLocalStorageService, ManageCartItemsLocalStorageService>();


await builder.Build().RunAsync();


