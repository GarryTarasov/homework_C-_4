// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Ввелите число");
int nunb = int.Parse(Console.ReadLine());
int summ = 0;
while (nunb > 0)
{
summ = summ + nunb % 10;
nunb = nunb /10 ;
 }
 Console.WriteLine(summ);