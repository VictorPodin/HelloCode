// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
//
// Сделаем вводимыми размерность массива рандомами с одной цифрой, (0;9)
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
void FillArrayRandomNumbers(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(0, 10);
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
Console.WriteLine();
int[] GetArraySumRows(int[,] arr)
{
    int[] sumArr = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumArr[i] += arr[i, j];
        }
    }
    return sumArr;
}
int[] newArr = GetArraySumRows(array);
// Для проверки можно раскомментировать ниже
// for (int i = 0; i < newArr.Length; i++)
// {
//     Console.WriteLine(newArr[i]);
// }
int GetIndexOfMin(int[] arr)
{
    int min = arr[0];
    int indexMin = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            indexMin = i;
        }
    }
    return indexMin;
}
Console.WriteLine();
int stringMin = GetIndexOfMin(newArr) + 1;
Console.WriteLine(stringMin + " строка");