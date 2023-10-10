// See https://aka.ms/new-console-template for more information

using System.Collections;


string[] colors = { "elma", "karpuz", "armut", "çilek" };

Console.WriteLine(colors.Length);


for (int i = 0; i < colors.Length; i += 2)
{
    Console.WriteLine(colors[i]);
}


for (int i = colors.Length - 1; i >= 0; i--)
{
    Console.WriteLine(colors[i]);
}

