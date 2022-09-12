// даны 2 неотрицательных числа m и n. 
//Напишите программу вычисления функции Аккермана с помощью рекурсии..
using System;
class Program
{

static void Main(string[] args)
{
    Console.WriteLine("Введите неотрицательное число M");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите неотрицательное число N");
    int N = Convert.ToInt32(Console.ReadLine());
        
    int Accerman (int M, int N)
    {
        if(M==0) 
        {
            return (N+1);
        }
        else if (N==0&M>0) 
        {
            return Accerman((M-1),1);
        }
        else 
        {
            return Accerman((M-1),Accerman(M,(N-1)));
        }             
    }
    Console.WriteLine(Accerman(M,N));
    
} 
}
