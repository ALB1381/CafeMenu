
using CafeMenu.Design.Assembly;
using CafeMenu.Design.Assembly.Core.Services;
using CafeMenu.Design.Assembly.Core.Services.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7103/") });
builder.Services.AddTransient<IItemServices,ItemServices>();
await builder.Build().RunAsync();
