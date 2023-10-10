// See https://aka.ms/new-console-template for more information

Start();

void Start()
{
    int x = 100;
    Console.WriteLine("X First Value: " + x);
    x = DoubleIt(x);
    Console.WriteLine("X Return Value: " + x);
    double y = Squart(x);
    Console.WriteLine("Y Value: " + y);
}

int DoubleIt(int x)
{
    return x * 2;
}

double Squart(int x)
{
    return Math.Sqrt(Convert.ToDouble(x));
}