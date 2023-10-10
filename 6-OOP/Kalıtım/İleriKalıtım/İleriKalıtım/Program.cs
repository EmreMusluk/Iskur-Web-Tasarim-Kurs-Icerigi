// See https://aka.ms/new-console-template for more information
using İleriKalıtım;


Egitmen egitmen = new Egitmen();
egitmen.Ad = "Hilal";
egitmen.Soyad = "Arslan";
egitmen.Maas = 15000;
egitmen.Unvan = "Game Developer";
var date = new DateTime(1997, 01, 01);
egitmen.DogumTarihi = date;
Console.WriteLine(egitmen.YasHesapla());
Console.WriteLine(egitmen.MaasHesapla());
Console.WriteLine(egitmen.FullName());
