using CafeMenu.AdminPanel.Components;
using CafeMenu.AdminPanel.Core.Services;
using CafeMenu.AdminPanel.Core.Services.Interfaces;
using CafeMenu.Data.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddDbContext<CafeContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CafeConnectionString"));
});
builder.Services.AddTransient<IItemService, ItemService>();
builder.Services.AddTransient<IItemGroupService, ItemGroupService>();
builder.Services.AddTransient<IToolService, ToolService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
