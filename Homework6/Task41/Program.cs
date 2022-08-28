//Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите через запятую M чисел");
        int qty=0;
        string numbers =Console.ReadLine();
        string[] array=numbers.Split (",");
        int[]arrayInt=new int[array.Length];
        for (int i = 0; i <array.Length; i++)
        {
             arrayInt[i]=int.Parse(array[i]);
             if (arrayInt[i]>0)
                {
                    qty+=1;
                }
        }
        Console.WriteLine (qty);       
    }    
}