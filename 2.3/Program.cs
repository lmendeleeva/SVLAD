// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());
if (a > 7 || a < 1)
{
    Console.WriteLine("Нет такого дня!");
    return;
}

switch(a)
{
    case 6: Console.WriteLine("Вых");
    break;

    case 7: Console.WriteLine("Вых");
    break;

    default: Console.WriteLine("Не вых");
    break;

}

