﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
//6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введи нижний предел массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи Верхний предел массива");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи желательное количество элеентов в массиве");
int summ = Convert.ToInt32(Console.ReadLine());
int[] array = new int[summ];
Random myRandom = new Random();
Console.WriteLine("рандомный массив из "+summ+ " элементов от "+ min+" до "+max);

for (int i = 0; i < array.Length; i++)
{
array[i] = myRandom.Next(min, max+1);
}
Console.WriteLine("вот, твой массив из восьми элементов [" + string.Join(", ",array) + "]");
