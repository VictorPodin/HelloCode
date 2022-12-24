// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
//
//Сделаем вводимыми число строк и столбцов и заполним массив рандомами с одной цифрой, (0;9)
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
void SortArrayMaxToMinInRow(int[,] arr)
{
    int tmp;
    bool flag; // этой переменной делаю пометку в массиве. Если при проходе ничего менять местами не пришлось - отсортирован.
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        flag = false; // для входа в цикл сортировки
        while (flag == false)  //мне просто интересно, не лучше ли так чем через for c
        {
          flag = true; // если не придется ничего сортировать значение останется
          for (int j = 0; j < arr.GetLength(1) - 1; j++)
          {
              if (arr[i, j + 1] > arr[i, j])
                {
                    tmp = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = tmp;
                    flag = false; 
                }
           } 
        }
    }
}
FillArrayRandomNumbers(array);
PrintArray(array);
Console.WriteLine();
SortArrayMaxToMinInRow(array);
PrintArray(array);