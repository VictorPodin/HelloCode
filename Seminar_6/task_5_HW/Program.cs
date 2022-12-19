// Задача 3*. Найдите сумму произведений пар чисел в одномерном целочисленном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Если кол-во элементов нечетное, то элемент посередине не учитывать.
// Результат сложения вывести на экран.
// 1, 3, 8, 3, 2 -> 11
// 8, 3, 4, 2 -> 28
Console.WriteLine("Из скольки элементов массив желаете?");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = new int[lenght];
void FillArrayRandomNumbers(int[] collection)
{
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10); //числа до 10
        Console.Write(" " + collection[index]);
        index++;
    }
}
FillArrayRandomNumbers(array);
int GetProductOfPairNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0, j = lenght - 1; i < lenght / 2; i++, j--)
    {
        sum = array[i] * array[j] + sum;
    }
    return sum;
}
int sumprod = GetProductOfPairNumbers(array);
Console.WriteLine(" суммa произведений пар чисел = " + sumprod);