// Напишите программу, которая задаёт массив из N элементов
// и выводит их на экран.

using System;
class Program
{
    
    static void PrintArray(int[] array)
    {
        int count = array.Length;
        Console.Write($"[{array[0]},");
        for (int i = 1; i < count-1; i++)
        {
            Console.Write($"{array[i]},");
        }
        Console.Write($"{array[array.Length-1]}]");
    }


    static void Main(string[] args)
    {    

       Console.WriteLine("введите число элементов массива N:");
       int N = Convert.ToInt32(Console.ReadLine());

       int[] array = new int[N];

       for (int i = 0; i < N; i++)
       {
            Console.WriteLine("введите элементы массива");
            array[i] = Convert.ToInt32(Console.ReadLine());
       }

        PrintArray (array);
    }
}
