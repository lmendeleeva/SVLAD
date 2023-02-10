// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Clear();
// int a = Convert.ToInt32(Console.ReadLine());
// if (a < 0)
// {
//     a*= -1;//a = a*-1  
// }
// if (a < 100)
// {
//     Console.WriteLine("Такой цифры нет!"); 
//     return; //когда программа заканчивается
// }
// while (a > 999)
// {
//      a/= 10; //a = a/10
// }
// a %= 10; //a=a%10
// Console.WriteLine(a);

Console.Clear();
string a = Console.ReadLine();
if (Convert.ToString(a[0]) == "-")//строковые данные пишутся в ""
{
    Console.WriteLine(a[3]);   
    return; //либо писать тут return, либо перед Console.WriteLine(a[2]) писать Else
}
Console.WriteLine(a[2]);


