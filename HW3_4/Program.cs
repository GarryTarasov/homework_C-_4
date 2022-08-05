// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
//6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введи первый элемент массива");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второй элемент массива");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи третий элемент массива");
int C = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи четвертый элемент массива");
int D = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи пятый эллимент массива");
int E = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи шестой эллеент массива");
int F = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи седьмой элемент массива");
int G = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи восьмой элемент массива");
int H = Convert.ToInt32(Console.ReadLine());
int[] array = new int[8] { A,B,C,D,E,F,G,H };
Console.WriteLine("вот, твой массив из восьми элементов [" + string.Join(", ",array) + "]");
