// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
//6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введи нижний предел массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи Верхний предел массива");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = new int[8];
Random myRandom = new Random();
 Console.WriteLine("рандомный массив из 8 эллиментов от "+ min+" до "+max);
for (int i = 0; i < array.Length; i++)
{
array[i] = myRandom.Next(min, max+1);
}
Console.WriteLine("[" + string.Join(", ",array) + "]");