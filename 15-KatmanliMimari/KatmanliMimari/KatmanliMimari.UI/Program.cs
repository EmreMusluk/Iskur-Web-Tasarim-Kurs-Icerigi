using KatmanliMimari.Dl;
using KatmanliMimari.Ent;
using KatmanliMimari.Rep.Abstracts;
using KatmanliMimari.Rep.Concrete;
using KatmanliMimari.UI.Models;
using KatmanliMimari.Uow;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MyContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnect")));
builder.Services.AddScoped<IPersonelRep, PersonelRep<Personel>>();
builder.Services.AddScoped<IUnit, Unit>();
builder.Services.AddScoped<PersonelModel>();
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
