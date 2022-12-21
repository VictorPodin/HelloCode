// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
// Тип данных для элементов выбрать double, наличие ненулевой дробной части обязательно.
// m = 3, n = 4.
// 0.5  7.96  -2.78  -0.2
// 1.7  -3.3   8.574 -9.9
// 8.5  7.87   -7.1   9.15
//
// Обьявим массив и запросим его размер у пользователя
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] arrayOfRealNumbers = new double[m, n];
//теперь заполним даблами (-10;10) с точностью до сотых. В примере до тысячных есть, но не суть...
void FillArrayRandomRealNumbers(double[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = (double)random.Next(-1000, 1001) / 100;   //  можно еще вот так  random.Next(-10, 11) + Math.Round(random.NextDouble(), 2);
        }
    }
}
void PrintArray(double[,] arr)
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
FillArrayRandomRealNumbers(arrayOfRealNumbers);
PrintArray(arrayOfRealNumbers); 