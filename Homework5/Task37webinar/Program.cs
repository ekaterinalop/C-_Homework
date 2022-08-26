// Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.

using System;

class Program
{
    static void Main(string[] args)
    {
       int N=1;
       N=new Random().Next(1,10);
       int[] array= new int [N];
       int N2=1;
       if (N%2!=0)
        {
            N2=N/2+1;
        } 
       else N2=N/2;
        
        int[] arrayNew=new int[N2];
        for (int i = 0; i < N; i++)
        {
            array[i]=new Random().Next(0,10);
            Console.Write($"{array[i]},");  
        }
        Console.WriteLine(); 
        
        if (N%2==0)
         {
            for (int i = 0; i < N2; i++)
            {
                arrayNew[i]=array[i]*array[(N-i)-1];
                Console.Write($"{arrayNew[i]},");  
            }
         }
          else    
            {for (int i = 0; i < (N2-1); i++)
                {
                
                    arrayNew[i]=array[i]*array[(N-i)-1];
                    Console.Write($"{arrayNew[i]},");
                
                }  
                                   
                    arrayNew[N2-1]=array[N2-1];
                    Console.Write($"{arrayNew[N2-1]},");
            }
            
            
    }
    
}    
