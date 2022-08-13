using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите число:");
        string number = Console.ReadLine();
    if (number.Length >= 3)
    { 
        Console.WriteLine(number[2]);
    } 
    else
    Console.WriteLine("третьей цифры нет");

    }
}

