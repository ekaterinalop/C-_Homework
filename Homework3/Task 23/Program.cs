// Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите число:");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i=1; i<number; i++)
        {
            Console.Write($"{Math.Pow(i,3)}, ");
        }
        Console.Write(Math.Pow(number,3));
    }
}

