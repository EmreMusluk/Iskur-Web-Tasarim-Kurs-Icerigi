//FirstMVC �st�nde sa� t�kla new folder ekle ad� controllers.Sonra controllers �st�nde sa� t�kla ekle diyip controller(denetliyici) ekliyoruz onu mvc empty(bo�) olarak se�iyoruz

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
    pattern: "{controller=Home}/{action=Index}/{id?}");     //Kullan�c� program� ilk a�t���nda home controllera gidiyo.controller bir class a��l��ta home controllera gidiyo class i�inde index metodu var id de opsiyoneldir.

app.Run();
