﻿// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

ConsoleColor frontColor = ConsoleColor.White;
ConsoleColor backColor = ConsoleColor.Red;
Console.BackgroundColor = backColor;
Console.ForegroundColor = frontColor;

int x = 100;
x += 150;
decimal y = 100.25M;
bool value1 = true;
string name = "Şamil";

Console.WriteLine("int: " + x);
Console.WriteLine("decimal: " + y);
Console.WriteLine("bool: " + value1);
Console.WriteLine("string: " + name);

