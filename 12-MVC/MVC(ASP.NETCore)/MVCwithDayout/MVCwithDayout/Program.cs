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
View �st�nde yeni klas�r ekliyosun, ad� Shared.Shared klas�r�nde ekle diyosun yeni ��e diyosun.Razar d�zenini arat�p onu ekliyosun 
Layout �stte sabit kalan pencere men�s� ve altta de�i�en sayfalar muhabbetine deniyor.
 
 */