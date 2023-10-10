// See https://aka.ms/new-console-template for more information
object frontColor = ConsoleColor.White;
ConsoleColor backColor = ConsoleColor.Red;
Console.BackgroundColor = backColor;
//Cascade
Console.ForegroundColor = (ConsoleColor) frontColor;

//object en az özelliği tutan tiptir.
//Combobox hem int tutuyor hem string ya da başka veritiplerini bizim ne vericeğimiz belli olmadığı için object olarak alır biz kendimiz veritiğini çeviririz.
object x = 100;
x = Convert.ToInt32(x) + 150;
object y = 100.25M;
object value1 = true;
var name = "Şamil";

Console.WriteLine("int: " + x);
Console.WriteLine("decimal: " + y);
Console.WriteLine("bool: " + value1);
Console.WriteLine("string: " + name);

