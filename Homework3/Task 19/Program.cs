// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите пятизначное число:");
        string number = Console.ReadLine();
        string[] result ={"да","нет"};

        if ((number[0]==number[4])&(number[1]==number[3]))
        {
            Console.WriteLine(result[0]);
        }
        else
        Console.WriteLine(result[1]);
    }
}
        
