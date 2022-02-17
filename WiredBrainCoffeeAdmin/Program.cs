using WiredBrainCoffeeAdmin.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("WiredBrain") ?? "Data Source=WiredBrain.db";
builder.Services.AddSqlite<WiredBrainContext>(connectionString);
// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();
await CreateDb(app.Services, app.Logger);

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

async Task CreateDb(IServiceProvider services, ILogger logger)
{
    using var db = services.CreateScope().ServiceProvider.GetRequiredService<WiredBrainContext>();
    await db.Database.MigrateAsync();
}