// заполнит спирально массив 4 на 4.

using System;
class Program
{
static void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
} 

static void Main(string[] args)
{
int M=4;
int N=4;
int [,]array=new int [M,N];
int item = 1;
int i=0;
int j=0;

while (item<=M*N)
{
   array[i,j]= item;
if (i<=j+1&& i+j<M-1)
{
    j++;
}
else if (i<j&&i+j>=N-1)
{
    i++;
}
else if (i>=j&&i+j>M-1)
{
    j--;
}
else 
{
    i--;
}
item=item+1;

}
PrintArray(array);
}
}



