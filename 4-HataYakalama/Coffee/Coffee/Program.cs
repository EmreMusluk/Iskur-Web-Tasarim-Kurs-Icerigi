// See https://aka.ms/new-console-template for more information

Start();
int age = 0;


void Start()
{
    Console.WriteLine("First name : ");
    //??? soru işareti name null olabilir uyarmana gerek yok demek
    string? name = Console.ReadLine();
    Console.WriteLine($"Hello!  {name} How old are you? ");

    try
    {
        age = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Sayısal değer gir");
        Console.ReadLine();
        Start();
        throw;
    }

    //try
    //{
    //    age = Convert.ToInt32(Console.ReadLine());
    //}
    //catch (Exception ex)
    //{
    //    Console.WriteLine(ex.Message);
    //    Console.ReadLine();
    //    throw;
    //}


    if (age >= 18)
    {
        Console.WriteLine($"{name} Welcome to the Univercity");
    }
    else
    {
        Console.WriteLine($"{name} You can enter after {18 - age} years");
    }
}