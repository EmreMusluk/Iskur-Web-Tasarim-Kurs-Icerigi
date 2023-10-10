// See https://aka.ms/new-console-template for more information
using AnaProgram;

Musteri musteri = new Musteri();
musteri.SetKkNo("4587695847586523");
musteri.SetTelNo("254215");
Console.WriteLine(musteri.GetKkNo());

Kurumsal kMusteri = new Kurumsal();
kMusteri.TelNoYaz();