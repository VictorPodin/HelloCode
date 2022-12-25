// Задача 3: Задайте две квадратные матрицы одинакового размера. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица:
// 18 20
// 15 18
//
// Сделаем вводимыми размерность КВАДРАТНОГО массива рандомами с одной цифрой, (0;9)
Console.Write("Введите размерность двух квадратных матриц: ");
int dim = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[dim, dim];
int[,] matrix2 = new int[dim, dim];
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
void PrintTwoQuadMatrix(int[,] arr1, int[,] arr2)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            Console.Write(arr1[i, j] + " ");
        }
        Console.Write("| ");
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            Console.Write(arr2[i, j] + " ");
        }
        Console.WriteLine();
    }
}
FillArrayRandomNumbers(matrix1);
// PrintArray(matrix1);
// Console.WriteLine();
FillArrayRandomNumbers(matrix2);
// PrintArray(matrix2);
// Console.WriteLine();
PrintTwoQuadMatrix(matrix1, matrix2);
int[,] MultiplyTwoMatrix(int[,] arr1, int[,] arr2)
{
    int[,] resMatrix = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                resMatrix[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return resMatrix;
}
int[,] MultiplyMatrix = MultiplyTwoMatrix(matrix1, matrix2);
Console.WriteLine("Результат перемножения матриц:");
PrintArray(MultiplyMatrix);