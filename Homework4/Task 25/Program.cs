// Напишите цикл, который принимает на вход два числа (A и B)  и 
// возводит число A в натуральную степень B.

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите 2 числа:");
        int numberA = Convert.ToInt32(Console.ReadLine());
        int numberB = Convert.ToInt32(Console.ReadLine());
        int result =(1);
        int count =(1);
        while (count<=numberB)
        {
            result = result * numberA;
            count++;
        }          
        Console.WriteLine(result);
    }
}
