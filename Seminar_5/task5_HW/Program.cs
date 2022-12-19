﻿// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3.3 7.76 22 2 78.67] -> 76.67
Console.WriteLine("Из скольки элементов массив желаете?");
int lenght = Convert.ToInt32(Console.ReadLine());
double[] realarray = new double[lenght];
void FillArrayRandomRealNumbers(double[] collection)
{
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10000); //ограничимся числами до 100
        collection[index] = collection[index] / 100; // этим добьемся чтоб была дробная часть
        Console.WriteLine(" " + collection[index]);
        index++;
    }
}
FillArrayRandomRealNumbers(realarray);
int GetIndexOfMax(double[] collection)
{
    int index = 0;
    int indexmax = 0;
    while (index < lenght)
    {
        if (collection[index] > collection[indexmax])
        {
            indexmax = index;
        }
        index++;
    }
    return indexmax;
}
int GetIndexOfMin(double[] collection)
{
    int index = 0;
    int indexmin = 0;
    while (index < lenght)
    {
        if (collection[index] < collection[indexmin])
        {
            indexmin = index;
        }
        index++;
    }
    return indexmin;
}
int max = GetIndexOfMax(realarray);
int min = GetIndexOfMin(realarray);
Console.WriteLine("Max " + realarray[max]);
Console.WriteLine("Min " + realarray[min]);
double difmaxmin = realarray[max] - realarray[min];
Console.WriteLine("Разница максимального и минимального элемента " + Math.Round(difmaxmin, 2));