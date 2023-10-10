// See https://aka.ms/new-console-template for more information
object frontColor = ConsoleColor.White;
ConsoleColor backColor = ConsoleColor.Black;
Console.BackgroundColor = backColor;
//Cascade
Console.ForegroundColor = (ConsoleColor)frontColor;

//Sayısal ve string değerler convert ile yapılır.Diğerleri Cascading ile ToString() de vardır.
//String ile sayısal veri toplarken sayısal tipi stringe çevirir.
decimal a = 1.25M;
int b = 55;
int sum = Convert.ToInt32(a) + b;
  
string name = "Hilal";
string surName = "Arslan";
int tc = 12345;
string fullName = $"{tc} {name}-{surName}";
Console.WriteLine(fullName);
Console.WriteLine(tc + " " + name + " " + surName + " ");


