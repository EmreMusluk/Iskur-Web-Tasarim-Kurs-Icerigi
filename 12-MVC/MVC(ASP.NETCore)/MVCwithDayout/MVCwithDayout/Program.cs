var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

/*
View üstünde yeni klasör ekliyosun, adý Shared.Shared klasöründe ekle diyosun yeni öðe diyosun.Razar düzenini aratýp onu ekliyosun 
Layout üstte sabit kalan pencere menüsü ve altta deðiþen sayfalar muhabbetine deniyor.
 
 */