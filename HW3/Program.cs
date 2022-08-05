// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
//6, 1, 33 -> [6, 1, 33]

Console.WriteLine("привет, вот посмотри");
int[] array = new int[8];
Random myRandom = new Random();
Console.WriteLine("рандомный массив из 8 эллиментов от 0 до 9999");
for (int i = 0; i < array.Length; i++)
{
array[i] = myRandom.Next(0, 999999);
}
Console.WriteLine("вот, твой массив из восьми эллементов [" + string.Join(", ",array) + "]");
