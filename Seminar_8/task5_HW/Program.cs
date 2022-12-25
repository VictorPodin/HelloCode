// Задача 4*. Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив. 
// Обратите внимание, что максимальный размер такого массива ограничен. 
// Проверку эл-та на присутствие в массиве можно вынести в отдельную функцию.
// Например,
// 11 22 78
// 12 47 96
// 25 87 88
//
// Сделаем вводимыми размерность КВАДРАТНОГО массива рандомами с одной цифрой, (0;9)
//Сделаем вводимыми число строк и столбцов и заполним массив рандомами с одной цифрой, (0;9)
void FillArrayRandomUniqNumbers(int[,] arr)
{
    Random random = new Random();
    int number;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            number = random.Next(10, 100);
            while (CheckRepeatElem(arr, number) == true) 
            {
                 number = random.Next(10, 100);
            }
            arr[i, j] = number;
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
bool CheckRepeatElem(int[,] arr, int num)
{
    bool flag = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == num)
            {
                flag = true;
            }
        }
    }
    return flag;
}
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
if(rows*columns < 90)
{
    int[,] array = new int[rows, columns];
    FillArrayRandomUniqNumbers(array);
    PrintArray(array);
}
else
{
    Console.WriteLine("В такой размерности не получится заполнить массив неповторяющимися двузначными числами");
}