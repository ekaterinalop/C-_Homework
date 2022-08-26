// Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество элементов массива");
        int N =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваш массив");
        int[] array=new int[N];
        int evenSum=0;
        int i = 0;
        while (i < N)
        {
             array[i]=new Random().Next(0,1000);
             Console.Write($"{array[i]}, ");
             if ((i+1)%2>0)
            { 
                evenSum+=array[i];
            }
            else  evenSum+=0;
        i++;
  
        }
        Console.WriteLine($"из них сумма значений на нечетных позициях {evenSum}.");
    }    
}
