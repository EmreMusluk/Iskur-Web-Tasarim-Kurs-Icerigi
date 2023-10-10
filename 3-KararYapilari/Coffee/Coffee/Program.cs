// See https://aka.ms/new-console-template for more information

Start();

void Start()
{
    Console.WriteLine("First name : ");
    string name = Console.ReadLine();

    Console.WriteLine($"Hello!  {name} How old are you? ");
    int age = Convert.ToInt32(Console.ReadLine());

    if (age >= 18)
    {
        Console.WriteLine($"{name} Welcome to the Univercity");
    }
    else
    {
        Console.WriteLine($"{name} You can enter after {18 - age} years");
    }
}