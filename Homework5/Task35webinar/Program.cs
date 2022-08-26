//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array=new int[123];
        int Qty=0;
        for (int i = 0; i < array.GetLength(0);  i++)
        {
             array[i]=new Random().Next(1,1000);
             Console.Write($"{array[i]}, ");
            
            if (array[i]<=99&array[i]>=10)
            { 
                Qty+=1;
            }
            else Qty+=0;
  
        }
        Console.WriteLine($"из них лежат в отрезке [10,99] {Qty}.");
    }    
}