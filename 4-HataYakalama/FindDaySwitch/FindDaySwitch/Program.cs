// See https://aka.ms/new-console-template for more information

Start();

void Start()
{
    try
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
        Console.ReadLine();
        Start();
    }

    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.ReadLine();
        Start();
    }
}