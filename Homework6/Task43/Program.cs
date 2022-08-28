//Напишите программу, которая найдёт точку пересечения двух прямых, 
//y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] lines=new int[2,2];

        Console.WriteLine("Введите значение k1, для уравнения y = k1 * x + b1");
        lines[0,0]=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение b1, для уравнения y = k1 * x + b1");
        lines[0,1]=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение k2, для уравнения y = k2 * x + b2");
        lines[1,0]=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение b2, для уравнения y = k2 * x + b2");
        lines[1,1]=Convert.ToInt32(Console.ReadLine());
        
        int x = (lines[1,1]-lines[0,1])/(lines[0,0]-lines[1,0]);
        //x=(b2-b1)/(k1-k2);
        int y = x*(lines[0,0]-lines[0,1]);
        //y=k1*x+b1;

         Console.WriteLine ($"координаты точки пересечения прямых y={lines[0,0]}*x+ {lines[0,1]} и y={lines[1,0]}*x+ {lines[1,1]} это [{x};{y}]");  
        }
           
    }    
