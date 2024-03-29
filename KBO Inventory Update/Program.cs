using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using IgniteUI.Blazor.Controls;
using KBO_Inventory_Update;

using KBO_Inventory_Update.Models;
using KBO_Inventory_Update.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();

builder.Services.AddScoped<KboInventoryTicketsService>();
RegisterIgniteUI(builder.Services);

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavDrawerModule),
        typeof(IgbRippleModule),
        typeof(IgbButtonModule),
        typeof(IgbGridModule),
        typeof(IgbCheckboxModule),
        typeof(IgbPieChartModule),
        typeof(IgbCategoryChartModule)
    );
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
