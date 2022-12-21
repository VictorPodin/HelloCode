// Задача 3. Задайте двумерный массив из трехзначных целых чисел (не менее 100 элементов). 
// В каждом столбце найдите среднее арифметическое среди тех элементов, 
// которые являются палиндромами (если палиндромов нет, то среднее арифметическое считать равным 0). 
// Полученные средние арифметические занести в одномерный массив.
// Например, задан массив:
// 100 404 504 225
// 550 478 800 363
// 505 101 410 479
// => [505, 252.5, 0, 363 ]
void FillArrayRandomTripleDigitNumbers(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(100, 1000);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
// создадим функцию считающую среднее арифметическое из палиндромов в столбце
double[] GetArrayOfAverageInColumnIfPalindrom(int[,] arr, int n)
{
    double[] arrayAverages = new double[n];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int countOfPalindrom = 0;
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            if (arr[i, j] / 100 == arr[i, j] % 10)
            {
                sum += arr[i, j];
                countOfPalindrom++;
            }
        }
        if (countOfPalindrom == 0) { arrayAverages[j] = 0; }
        else { arrayAverages[j] = (double)sum / countOfPalindrom; }
    }
    return arrayAverages;
}
Console.WriteLine("Создаем массив, не менее 100 элементов");
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m * n < 100) { Console.WriteLine("У нас меньше 100 элементов, давайте снова"); }
else
{
    int[,] array = new int[m, n];
    FillArrayRandomTripleDigitNumbers(array);
    PrintArray(array);
    double[] arrayAverages = GetArrayOfAverageInColumnIfPalindrom(array, n);
    Console.Write("=> [");
    for (int i = 0; i < arrayAverages.Length; i++)
    {
        Console.Write(Math.Round(arrayAverages[i], 2) + " ");
    }
    Console.Write("]");
}

