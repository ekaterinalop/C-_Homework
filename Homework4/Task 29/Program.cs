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
        Console.WriteLine("введите число элементов массива N (от 0до9):");
        int N = Convert.ToInt32(Console.ReadLine());

        //создаем генератор случайных чисел
        var rand = new Random();
                
        int[] array = new int[N];

        for (int i = 0; i < N; i++)
        {
            array[i] = rand.Next(10); // случайное число от 0 до 9
        }

        PrintArray (array);
    }
}
