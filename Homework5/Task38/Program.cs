//массив вещественных чисел
//найти разницу между макс и мин
using System;

class Program
{
    static void Main(string[] args)
    {
       int[] array= {10,11,79,9,9};
       int min=array[0];
       int max=array[0];
       int i=0;
       int result=0;
    while (i<5)
        {
            if (min>=array[i])
            {
                min=array[i];
            }
                else if (max<=array[i])    
                 {
                    max=array[i];
                 }         
        
        i=i+1;
        }
    result=max-min;    
    Console.WriteLine($"разница равна {result}.");  
    }
    
}    
