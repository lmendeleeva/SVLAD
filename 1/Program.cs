﻿// // //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

Console.Clear();
int a = Convert.ToInt32(Console.ReadLine()); // int.Parse(Console.ReadLine())
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("a > b");
} 
else if (b > a) 
{
    Console.WriteLine("b > a");
}
else
{
    Console.WriteLine("a = b");
}
    
