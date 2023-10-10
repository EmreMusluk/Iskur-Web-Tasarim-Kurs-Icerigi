//FirstMVC üstünde sað týkla new folder ekle adý controllers.Sonra controllers üstünde sað týkla ekle diyip controller(denetliyici) ekliyoruz onu mvc empty(boþ) olarak seçiyoruz

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

app.UseRouting();       //

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");     //Kullanýcý programý ilk açtýðýnda home controllera gidiyo.controller bir class açýlýþta home controllera gidiyo class içinde index metodu var id de opsiyoneldir.

app.Run();
