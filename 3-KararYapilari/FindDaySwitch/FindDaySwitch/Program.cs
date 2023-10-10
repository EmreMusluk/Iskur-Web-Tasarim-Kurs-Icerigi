// See https://aka.ms/new-console-template for more information


Start();

void Start()
{
	Console.WriteLine("Hangi gündeyiz?");
    int day = Convert.ToInt32(Console.ReadLine());
  
    switch (day)
    {
        case 1:
            Console.WriteLine("Pazartesi");
            break;
        case 2:
            Console.WriteLine("Salı");
            break;
        case 3:
            Console.WriteLine("Çarşamba");
            break;
        default:
            Console.WriteLine("yanlış");
            break;
    }
    Start();
}
