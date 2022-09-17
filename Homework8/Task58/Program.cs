// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.. 

using System;
class Program
{
static void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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
    Console.WriteLine("Введите количество строк матрицы M");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов матрицы N");
    int N = Convert.ToInt32(Console.ReadLine());
    int[,] array1 = new int[M, N];
    int[,] array2 = new int[M, N];

    CreateArray(array1);
    PrintArray(array1);
    Console.WriteLine();
    CreateArray(array2);
    PrintArray(array2);

    int[,] result = new int[M, N];
    for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    for (int k = 0; k < array2.GetLength(0); k++)
                    {
                        result[i,j] += array1[i,k] * array2[k,j];
                    }
                }
            }

    Console.WriteLine("Итог перемножения двух матриц");
    PrintArray(result);
}
}