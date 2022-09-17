// Задайте прямоугольный двумерный массив размером m×n,  
//будет находить строку с наименьшей суммой элементов.
using System;
class Program
{
    static void Main(string[] args)
{ 
Console.WriteLine("Введите количество строк массива M");
int M=Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива N, не равное количеству строк M");
int N=Convert.ToInt32 (Console.ReadLine());
float[,]arrayMN=new float [M,N];

    for (int i = 0; i < arrayMN.GetLength(0); i++)
        {
        for (int j = 0; j < arrayMN.GetLength(1); j++)
        {
            arrayMN[i,j]= new Random().Next(-100,100);
            Console.Write(arrayMN[i,j] + " ");
        }
        Console.WriteLine();
        }  
    
int index=1; // 1-я строка =1 к выводу в теминале для пользователя.
float[] ave=new float[M];
float min=ave[0];
float sum =0;
for (int i = 0; i < arrayMN.GetLength(0); i++)
    {
        for (int j = 0; j < arrayMN.GetLength(1); j++)
        {
         sum=sum+arrayMN[i,j];     
        }
        ave[i]=sum;
        sum=0;   
    }
for (int i = 0; i < M; i++)
    {
      if (ave[i]<=min)  
      index=i+1; 
      min=ave[i];
    }  

Console.WriteLine("Строка с наименьшей суммой элементов:"+ index);
}
}        


