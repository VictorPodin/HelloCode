// Задача 4*. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
//
Console.WriteLine("Введите количество строк/столбцов квадратного массива:");
int n = Convert.ToInt32(Console.ReadLine());
//  1-право, 2-вниз, 3-влево, 4-вверх
int[,] arraySpiral = new int[n, n];
void PrintStringArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] >= 10)
            {
                Console.Write(Convert.ToString(arr[i, j]) + " ");
            }
            else
            {
                Console.Write("0" + Convert.ToString(arr[i, j]) + " ");
            }
        }
        Console.WriteLine();
    }
}
void FillArraySpiral(int[,] arr)
{
    int bottom = arr.GetLength(0) - 1;
    int right = arr.GetLength(1) - 1;
    int left = 0;
    int top = 0;
    int colElem = arr.GetLength(0) * arr.GetLength(1);
    int countElem = 0;
    int startElem = 1;
    int direction = 1;  //  1-право, 2-вниз, 3-влево, 4-вверх
    while (countElem < colElem)
    {
        if (direction == 1)
        {
            for (int j = left, i = top; j <= right; j++)
            {
                arr[i, j] = startElem;
                startElem++;
                countElem++;
            }
            top++;
            direction++;
        }
        if (direction == 2)
        {
            for (int i = top, j = right; i <= bottom; i++)
            {
                arr[i, j] = startElem;
                startElem++;
                countElem++;
            }
            right--;
            direction++;
        }
        if (direction == 3)
        {
            for (int j = right, i = bottom; j >= left; j--)
            {
                arr[i, j] = startElem;
                startElem++;
                countElem++;
            }

            bottom--;
            direction++;
        }
        if (direction == 4)
        {
            for (int i = bottom, j = left; i >= top; i--)
            {
                arr[i, j] = startElem;
                startElem++;
                countElem++;
            }
            left++;
            direction = 1;
        }
    }
}
FillArraySpiral(arraySpiral);
PrintStringArray(arraySpiral);
