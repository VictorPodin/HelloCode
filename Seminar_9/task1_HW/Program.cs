// Задача 1: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Введите значение N:");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("N = " + N + "  → ＂");
void PrintNumsFromNto1(int n)
{
    if (n == 1)
    {
        Console.Write(n);
        return;
    }
    else
    {
        Console.Write(n + ", ");
        PrintNumsFromNto1(n - 1);
    }
}
PrintNumsFromNto1(N);
Console.Write("＂");