// See https://aka.ms/new-console-template for more information
int[] numbers = { 10, 15, 77, 42, 62 };
int counter = 0;
int sum = 0;

Title("For Döngüsü");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
    sum += numbers[i];
}
SumTitle();

sum = 0;

Title("Do-While Döngüsü");

do
{
    Console.WriteLine(numbers[counter]);
    sum += numbers[counter];
    counter++;
} while (counter < numbers.Length);
SumTitle();


counter = 0;
sum = 0;

Title("While Döngüsü");
while (counter < numbers.Length)
{
    Console.WriteLine(numbers[counter]);
    sum += numbers[counter];
    counter++;
}
SumTitle();


Title("Foreach Döngüsü");
int sum2 = 0;
foreach (var item in numbers)
{
    Console.WriteLine(item);
    sum2 += item;
}
SumTitle();

void Title(string title)
{
    Console.WriteLine("*************");
    Console.WriteLine(title);
    Console.WriteLine("*************");
}

void SumTitle()
{
    Console.WriteLine("---------------");
    Console.WriteLine($"Totel : {sum}");
    Console.WriteLine("---------------");
}

void Sum()
{
    sum += counter;
    counter++;
}