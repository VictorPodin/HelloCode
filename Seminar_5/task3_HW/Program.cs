// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine("Из скольки элементов массив желаете?");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = new int[lenght];
void FillArrayRandomTripleDigitNumbers(int[] collection)
{
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(100, 1000);
        // Console.Write(" " + collection[index]);
        index++;
    }
}
FillArrayRandomTripleDigitNumbers(array);
int CountOfEven = 0;
for (int i = 0; i < lenght; i++)
{
    if (array[i] % 2 == 0)
    {
        CountOfEven++;
    }  
}
Console.WriteLine("Четных чисел : " + CountOfEven);