Console.WriteLine("введите число");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (a <= n)
{   
    if (a % 2 == 0)
    {
        Console.WriteLine(a);
    }
    a += 1;
}
