// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9 (?)
// m = 3, n = 2 -> A(m,n) = 29 (?)
Console.WriteLine("Введите значение m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("m = " + m + "; n = " + n + "  → A(m,n) = ");
int CalculateAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if ((m > 0) && (n == 0))
    {
        return CalculateAkkerman(m - 1, 1);
    }
    else
    {
        return CalculateAkkerman(m - 1, CalculateAkkerman(m, n - 1));
    }
}
Console.WriteLine(CalculateAkkerman(m, n));
