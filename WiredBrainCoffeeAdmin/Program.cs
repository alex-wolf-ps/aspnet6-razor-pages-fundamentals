using WiredBrainCoffeeAdmin.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("WiredBrain") ?? "Data Source=WiredBrain.db";

builder.Services.AddSqlite<WiredBrainContext>(connectionString);
builder.Services.AddHttpClient();
builder.Services.AddHttpClient<ITicketService, TicketService>(httpClient =>
{
    httpClient.BaseAddress = new Uri("https://wiredbraincoffeeadmin.azurewebsites.net/");
});

// Add services to the container.
builder.Services.AddRazorPages();

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();