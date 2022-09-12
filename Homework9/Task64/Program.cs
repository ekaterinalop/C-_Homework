// Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
using System;
class Program
{

static void Main(string[] args)
{
    Console.WriteLine("Введите натуральное число M");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите натуральное число N, больше M");
    int N = Convert.ToInt32(Console.ReadLine());
        
    string result(int M, int N)
    {
        if(M<=N) return $"{M} " + result(M+1,N);
        else return string.Empty;

    }
    Console.WriteLine($"Натуральные числа в промежутке от M до N:{result(M,N)}");
    
} 
}