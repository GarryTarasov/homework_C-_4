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
Console.WriteLine("Введи пятый элемент массива");
int E = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи шестой элемент массива");
int F = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи седьмой элемент массива");
int G = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи восьмой элемент массива");
int H = Convert.ToInt32(Console.ReadLine());
int[] array = new int[8] { A,B,C,D,E,F,G,H };

//Тут мне пришлось использовать алгоритм Фишера — Йетса (Потомучто я больше ничего не нашол несчитая разные типы ревёрса массива. Но я хотел именно перемешанный)
{
   
    Random rand = new Random();
 
    for (int i = array.Length - 1; i >= 1; i--)
    {
        int j = rand.Next(i + 1);
 
        int tmp = array[j];
        array[j] = array[i];
        array[i] = tmp;
    }
}

Console.WriteLine("вот, твой рандомный массив из восьми эллементов [" + string.Join(", ",array) + "]");