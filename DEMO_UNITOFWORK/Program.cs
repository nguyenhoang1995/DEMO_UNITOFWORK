using DEMO_UNITOFWORK.Models;
using DEMO_UNITOFWORK.Repository;
using DEMO_UNITOFWORK.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlServer(builder.Configuration
   .GetConnectionString("ConnectDB"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
builder.Services.AddScoped<IOrderRepository, OrderServiceImp>();
builder.Services.AddScoped<IProductRepository, ProductServiceImp>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWorkImp>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.Run();
