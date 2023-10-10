// See https://aka.ms/new-console-template for more information

var frontColor = ConsoleColor.White;
ConsoleColor backColor = ConsoleColor.Red;
Console.BackgroundColor = backColor;
Console.ForegroundColor = frontColor;

//var'ı int yaptı en çok kullanılan veri tipini atar.
var x = 100;
x += 150;
var y = 100.25M;
var value1 = true;
var name = "Şamil";

Console.WriteLine("int: " + x);
Console.WriteLine("decimal: " + y);
Console.WriteLine("bool: " + value1);
Console.WriteLine("string: " + name);
