using PersonelProje.Data;
using PersonelProje.Models;
using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.Metot içinde newlenir kapanýr.
// Bu tarz classlarda builder.Services.AddScoped<Ulke>(); yazmasakta çalýþýr.
//Þehir tablosunda newlemedik bu kodu da eklemedik kendisi yine de otomatik newleniyor.
builder.Services.AddScoped<Ulke>();
//Singleton bir kere açar kapatmaz, devamlý çalýþýr.
builder.Services.AddSingleton<SqlConnection>();
//Bu tarz genel classlarda burada bu kodu yazmak zorundayýz otomatik newlemek için
builder.Services.AddScoped<PersonelModel>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
