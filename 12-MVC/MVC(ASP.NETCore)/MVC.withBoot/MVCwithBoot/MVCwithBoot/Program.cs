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
 *              ALGORÝTMAAAA
 * Ýlk promram.cs kodunu hocanýn whatssaptan attýðý kodu copy paste yaptýk
 * MVCwithBoot üstünde saðtýk new folder-> adý ViewS
 * ViewS üstü saðtýk new folder -> adý Shared
 * Shared üstü saðtýk new item(öðe) Razor layout(razor düzeni) ekliyoruz
 * 
 * Bootstrap sitesine git->Docs->Component->Navbar copy yapýyosun layoutta render body nin üstüne yapýþtýrýyosun
 * 
 *  MVCwithBoot üstünde saðtýk new folder->ADI Controllers
 *  controllerS üstü saðtýk ekle diyip denetleyici(controller) ekle diyosun empty(boþ) controller ekle diyosun.Adý kendiliðinden homecontroller oluyo zaten 
 *  
 *  View altýnda Home dosyasý açýyoruz.Burasý bizim anasayfamýz.Buranýn üzerinde  about, contact, index diye layoutlar(saðtýk->ekle->görünüm) ekliyoruz
 *  (EKLEDÝÐÝMÝZ LAYOUTLARIN KURULUMUNU SHARED DOSYASINDAKÝ LAYOUT YOLUNA YAPIYORUZ) 
 *  
 *  
 * */
