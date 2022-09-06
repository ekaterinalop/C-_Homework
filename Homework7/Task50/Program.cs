//на вход принимает позиции элемента в двумерном массиве
//возвращает значение этого элемента или же указание, что такого элемента нет.

using System;
class Program
{
    static void Main(string[] args)
{ 
Console.WriteLine("Введите номер строки элемента массива");
int row=int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента массива");
int column=int.Parse(Console.ReadLine());

int[,]arrayMN=new int [5,5];

    for (int i = 0; i < arrayMN.GetLength(0); i++)
        {
        for (int j = 0; j < arrayMN.GetLength(1); j++)
        {
            arrayMN[i,j]= new Random().Next(1,1000); 
            Console.Write(arrayMN[i,j] + " ");
        }
        Console.WriteLine();
        }   
   if (row>arrayMN.GetLength(0)||column>arrayMN.GetLength(1))
    {
       Console.WriteLine("такого элемента в массиве нет");
    }
    Console.WriteLine(arrayMN[(row-1),(column-1)]);
}   

}

