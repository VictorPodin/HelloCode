Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int min = 2;
if (N%2 != 0)
{
    N = N-1;
}
while (min <= N)
{
    Console.Write(min);
    if(N != min)
    {
    Console.Write(", ");
    }
    min = min + 2;
}