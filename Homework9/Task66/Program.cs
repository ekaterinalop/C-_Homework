// Задайте значения M и N. 
//Напишите программу, которая сумму натуральных элементов в промежутке от M до N.
using System;
class Program
{

static void Main(string[] args)
{
    Console.WriteLine("Введите натуральное число M");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите натуральное число N, больше M");
    int N = Convert.ToInt32(Console.ReadLine());
        
    int sum (int M, int N)
    {
        if (N<M) return 0;
        else return N + sum(M, N-1);

    }
    Console.WriteLine($"Сумма натуральных чисел в промежутке от M до N:{sum(M,N)}");
    
} 
}
