// Задача 2: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumNumsFromMtoN(int m, int n)
{
    if (n == m) return m;
    if (m < n) return m + SumNumsFromMtoN(m + 1, n);
    else return m + SumNumsFromMtoN(m - 1, n);
}
Console.WriteLine("Введите значение M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N:");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("M = " + M + "; N = " + N + "  → ");
if (M != N) { Console.Write(SumNumsFromMtoN(M, N)); }
else { Console.WriteLine("Числа одинаковые, a надо чтоб был промежуток"); }