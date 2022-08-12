Console.WriteLine("введите число a=");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b=");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число c=");
int c = Convert.ToInt32(Console.ReadLine());

if(a>b)
{
    if(a>c)
    {
        Console.WriteLine("max=");
        Console.WriteLine(a);
    }
    else
    {
        Console.WriteLine("max=");
        Console.WriteLine(c);
    }  
}
else
{
    if (b>c)
    {
        Console.WriteLine("max=");
        Console.WriteLine(b);
    }
    else
    {
        Console.WriteLine("max=");
        Console.WriteLine(c);
    }
}
