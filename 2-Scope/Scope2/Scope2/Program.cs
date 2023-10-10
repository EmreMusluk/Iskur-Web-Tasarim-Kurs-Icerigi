// See https://aka.ms/new-console-template for more information

int x = 100;

Start();

void Start()
{
    Console.WriteLine("x first value: " + x);
    DoubleIt(x);
    Console.WriteLine("x method after: " + x);
}

void DoubleIt(int x)
{
    x *= 2;
    Console.WriteLine("x - DoubuleIt method value: " + x);
}
