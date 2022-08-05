// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
//6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введи первый эллимент массива");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второй эллимент массива");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи третий эллимент массива");
int C = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи четвертый эллимент массива");
int D = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи пятый эллимент массива");
int E = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи шестой эллимент массива");
int F = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи седьмой эллимент массива");
int G = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи восьмой эллимент массива");
int H = Convert.ToInt32(Console.ReadLine());
int[] array = new int[8] { A,B,C,D,E,F,G,H };
Console.WriteLine("[" + string.Join(", ",array) + "]");
