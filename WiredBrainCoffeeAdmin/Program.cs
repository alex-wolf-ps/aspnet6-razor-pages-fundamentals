using WiredBrainCoffeeAdmin.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<WiredContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("WiredBrain")));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddHttpClient();
builder.Services.AddHttpClient<ITicketService, TicketService>(options =>
            options.BaseAddress = new Uri("https://wiredbraincoffeeadmin.azurewebsites.net/"));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    //app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    //context.Database.Migrate();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
