// Напишите программу, которая принимает на вход число
// выдаёт сумму цифр в числе

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите число:");
        string number = Console.ReadLine();

        int[] numberArray = new int[number.Length];
        int sum = 0;             
        for (int i=0; i<=(number.Length-1); i++)
        {
            numberArray[i] = Convert.ToInt32(number[i].ToString());
            sum = sum + numberArray[i];
        }          
        Console.WriteLine(sum);
    }
}
