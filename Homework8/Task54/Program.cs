// Задайте двумерный массив размером m×n,  
//упорядочит по убыванию элементы каждой строки двумерного массива.
using System;
class Program
{

static void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-1000, 1000);
        }
    }
}

static void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

static void Main(string[] args)
{
    Console.WriteLine("Введите количество строк массива M");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов массива N");
    int N = Convert.ToInt32(Console.ReadLine());
    int[,] arrayMN = new int[M, N];

    CreateArray(arrayMN);
    PrintArray(arrayMN);

    Console.WriteLine("Ваш массив упорядочили по убыванию");

    int temp;

    for (int i = 0; i < arrayMN.GetLength(0); i++)
    {
        for (int j = 0; j < N - 1; j++)
        {
            for (int k = 0; k < N - j - 1; k++)
            
                if (arrayMN[i, k] > arrayMN[i, k + 1])
                {
                    temp = arrayMN[i, k];
                    arrayMN[i, k] = arrayMN[i, k + 1];
                    arrayMN[i, k + 1] = temp;
                }

         }
    }
    PrintArray(arrayMN);  
    }
}



