using FirstEF.Data;
using Microsoft.EntityFrameworkCore;
using FirstEF.DTO;

namespace FirstEF.Models.Context
{
    //ENTITY FRAMEWORK
    //DBContext class yarat bu proje de bizim SalesContext

    //Classları yarat

    //appsetting.jason da Db bağlantı yaz
    //   "ConnectionStrings": {
    //  "ProductDatabase": "Server=DESKTOP-4GKM6HK\\SQLEXPRESS;Database=ProductDB;Trusted_Connection=True;"
    //},

    //program.cs sql context tanımı yap
    //------builder.Services.AddDbContext<SalesContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("ProductDatabase")));

    //Migration yap
    //Migration veritabanı ile senkronizasyon sağlar.
    //1 Add-Migration
    //Tools-Nuget pacage manager -  pacake manager console
    //Add-Migration migration adı
    //Add-Migration isim
    //Add-Migration değişiklikleri algılar.


    //2 Update-Database
    //Update-Database

    //3 Gerekli ise 1. adıma git
    //Diyelim ki Product tablomuza bir değişken daha ekledik sonrasında tekrar Add-Migration 'fiyateklendi' ve Update-Database deriz.

    //Bu işlemler sonucunda Sql de ProductDB adında database ve Product adında tablo oluşur.
    public class SalesContext : DbContext
    {
        //SalesContext DbContext classından kalıtım alır.DbContext de Microsoft.Entityframeworkcore den geliyor.NuGetden indirmiştik.
        //
        public SalesContext(DbContextOptions<SalesContext> db) : base(db)
        {

        }

        public DbSet<Product> Product { get; set; }

        public DbSet<Category> Category { get; set; }
    }
}
