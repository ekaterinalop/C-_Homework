// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

using System;
class Program
{

static void CreateArray3 (int [,,] array)    
{
    int item=new Random().Next(10, 20);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int k = 0; k < array.GetLength(2); k++) 
            {
            array[i,j,k]=item;
            item= array[i,j,k]+new Random().Next(0, 3);
            }
               
        }
    }
}
static void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++) 
            {
            Console.Write($"{array[i,j,k]} ({i},{j},{k})");
            }
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
    Console.WriteLine("Введите количество столбцов матрицы N");
    int K = Convert.ToInt32(Console.ReadLine());
    int [,,] array3=new int [M,N,K];

    CreateArray3 (array3);
    PrintArray(array3);
}

}