// Задача 2. Напишите программу, которая на вход принимает позиции (два индекса) элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет
//
// Чтоб было интереснее, массив будет не задан, а генерироваться, целочисленный (-9;9), ну и вывод для проверочки сделаем
// Обьявим массив и запросим его размер у пользователя
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
void FillArrayRandomNumbers(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(-9, 10);
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
FillArrayRandomNumbers(array);
PrintArray(array);
// сделаем метод, который выводит в консоль элемент целочисленного массива по заданной позиции
void PrintElementOfArrayOnPosition(int[,] arr)
{
    Console.WriteLine("Введите позицию искомого элемента: ");
    Console.Write("строка: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("столбец: ");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.Write("[" + row + ", " + column + "] => ");
    if (row > arr.GetLength(0) || column > arr.GetLength(1) || row <= 0 || column <= 0) { Console.WriteLine("Такого элемента в массиве нет!"); }
    else { Console.WriteLine(arr[row - 1, column - 1]); }
}
PrintElementOfArrayOnPosition(array);