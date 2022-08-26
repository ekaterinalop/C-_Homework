// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество элементов массива");
        int N =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваш массив");
        int[] array=new int[N];
        int OddQty=0;
        for (int i = 0; i < N;  i++)
        {
             array[i]=new Random().Next(100,1000);
             Console.Write($"{array[i]}, ");
             int odd=array[i]%2;
            if (odd<1)
            { 
                OddQty+=1;
            }
            else OddQty+=0;
  
        }
        Console.WriteLine($"из них четных {OddQty}.");
    }    
}