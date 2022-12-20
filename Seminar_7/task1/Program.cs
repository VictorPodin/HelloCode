// задать двумерный массив, найти элементы где оба индекса четные и заменить их квадратами
// создание и заполнение массива
// метод замены элемента квадратом changeelementstosquare
void ChangeElementsToSquare(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
}
int rowCount = 3;
int columnCount = 4;
int[,] array2 = new int[rowCount, columnCount];
void FillArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(2, 5);
        }
    }
}
void PrintArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
FillArray(array2);
PrintArray(array2);
ChangeElementsToSquare(array2);
PrintArray(array2);
