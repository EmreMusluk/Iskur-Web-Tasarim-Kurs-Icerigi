namespace BasitDiziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 15, 77, 42, 62 };
            int counter = 0;
            int sum = 0;

            Console.WriteLine("*************");
            Console.WriteLine("For Döngüsü");
            Console.WriteLine("*************");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                sum += numbers[i];
            }

            Console.WriteLine("---------------");
            Console.WriteLine($"Totel : {sum}");
            Console.WriteLine("---------------");

            sum = 0;

            Console.WriteLine("*************");
            Console.WriteLine("Do-While Döngüsü");
            Console.WriteLine("*************");

            do
            {
                Console.WriteLine(numbers[counter]);
                sum += numbers[counter];
                counter++;
            } while (counter < numbers.Length);
            Console.WriteLine("---------------");
            Console.WriteLine($"Totel : {sum}");
            Console.WriteLine("---------------");

            counter = 0;
            sum = 0;

            Console.WriteLine("*************");
            Console.WriteLine("While Döngüsü");
            Console.WriteLine("*************");

            while (counter < numbers.Length)
            {
                Console.WriteLine(numbers[counter]);
                sum += numbers[counter];
                counter++;
            }
            Console.WriteLine("---------------");
            Console.WriteLine($"Totel : {sum}");
            Console.WriteLine("---------------");

            Console.WriteLine("*************");
            Console.WriteLine("Foreach Döngüsü");
            Console.WriteLine("*************");

            int sum2 = 0;
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
                sum2 += item;
            }
            Console.WriteLine("---------------");
            Console.WriteLine($"Totel : {sum}");
            Console.WriteLine("---------------");

            Console.WriteLine();
        }
    }
}