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
 *              ALGOR�TMAAAA
 * �lk promram.cs kodunu hocan�n whatssaptan att��� kodu copy paste yapt�k
 * MVCwithBoot �st�nde sa�t�k new folder-> ad� ViewS
 * ViewS �st� sa�t�k new folder -> ad� Shared
 * Shared �st� sa�t�k new item(��e) Razor layout(razor d�zeni) ekliyoruz
 * 
 * Bootstrap sitesine git->Docs->Component->Navbar copy yap�yosun layoutta render body nin �st�ne yap��t�r�yosun
 * 
 *  MVCwithBoot �st�nde sa�t�k new folder->ADI Controllers
 *  controllerS �st� sa�t�k ekle diyip denetleyici(controller) ekle diyosun empty(bo�) controller ekle diyosun.Ad� kendili�inden homecontroller oluyo zaten 
 *  
 *  View alt�nda Home dosyas� a��yoruz.Buras� bizim anasayfam�z.Buran�n �zerinde  about, contact, index diye layoutlar(sa�t�k->ekle->g�r�n�m) ekliyoruz
 *  (EKLED���M�Z LAYOUTLARIN KURULUMUNU SHARED DOSYASINDAK� LAYOUT YOLUNA YAPIYORUZ) 
 *  
 *  
 * */
