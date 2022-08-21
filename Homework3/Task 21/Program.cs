// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите координаты двух точек x1,y1,z1 и x2,y2,z2, нажимая enter после каждого значения");
        int[] A = {Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())};
        int[] B = {Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())};
        double AB = (Math.Sqrt(Math.Pow((B[0]-A[0]),2)+Math.Pow((B[1]-A[1]),2)+Math.Pow((B[2]-A[2]),2)));

        Console.WriteLine($"Расстояние между ними в 3D ->{AB}");
    }
}
        
