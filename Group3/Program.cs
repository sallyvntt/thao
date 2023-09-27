using Group3.Db;
using Group3.Reponsitory;

using Group3.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();
//di
builder.Services.AddScoped<IAuthenService, AuthenServiceImp>();
builder.Services.AddScoped<IBrand, BrandService>();
builder.Services.AddScoped<ICat, CatService>();
builder.Services.AddScoped<ICreateAcountService, CreateAccountServiceImp>();
builder.Services.AddScoped<IBlogServices,BlogServiceImp>();
builder.Services.AddScoped<IItemRepository, ItemService>();
builder.Services.AddScoped<IProductRepository, ProductServiceImp>();


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Frontend/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Frontend}/{action=Index}/{id?}");


app.Run();

