// Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.

using System;
class Program
{
    static void Main(string[] args)
{ 
Console.WriteLine("Введите количество строк массива M");
int M=Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива N");
int N=Convert.ToInt32 (Console.ReadLine());
int[,]arrayMN=new int [M,N];
float[]ave=new float [N];
float sum=0;

    for (int i = 0; i < arrayMN.GetLength(0); i++)
    {
        for (int j = 0; j < arrayMN.GetLength(1); j++)
        {
            arrayMN[i,j]= new Random().Next(1,4); //изменить число после отладки 
            Console.Write(arrayMN[i,j] + " ");
            
        }
        Console.WriteLine();
    }
   Console.WriteLine("Среднеарифмитическое столбцов:");
    for (int j = 0; j < arrayMN.GetLength(1); j++)
    {
        for (int i = 0; i < arrayMN.GetLength(0); i++)
        {
         sum=sum+arrayMN[i,j];     
        }
        ave[j]=(sum)/M;
        Console.Write(ave[j]+" "); 
        sum=0;   
    }
   
    }
}   

        

