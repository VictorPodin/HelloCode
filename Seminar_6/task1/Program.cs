// рекурсия факториал
int get_factorial(int x)
{
    Console.WriteLine(x);
    if (x == 1)
    {
        return 1;
    }
    else
    {
        int res = get_factorial(x - 1);
        Console.WriteLine(res);
        return x * res;
    }
}


Console.WriteLine(get_factorial(5));
