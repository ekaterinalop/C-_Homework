// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

using System;
class Program
{
    static void Main(string[] args)
{ 
Console.WriteLine("Введите количество строк массива M");
int M=Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива N");
int N=Convert.ToInt32 (Console.ReadLine());
float[,]arrayMN=new float [M,N];

    for (int i = 0; i < arrayMN.GetLength(0); i++)
        {
        for (int j = 0; j < arrayMN.GetLength(1); j++)
        {
            arrayMN[i,j]= new Random().Next(-1000,1000); // ? отличается ли рандом для флоат 
            Console.Write(arrayMN[i,j] + " ");
        }
        Console.WriteLine();
        }   

}
        

}
