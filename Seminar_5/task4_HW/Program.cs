// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.WriteLine("Из скольки элементов массив желаете?");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = new int[lenght];
void FillArrayRandomNumbers(int[] collection)
{
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(-99, 100); //ограничимся двузначными числами
        // Console.Write(" " + collection[index]); 
        index++;
    }
}
FillArrayRandomNumbers(array);
int SumOffOddPosition = 0;
for (int i = 1; i < lenght; i +=2)
{
    SumOffOddPosition = SumOffOddPosition + array[i];
}
Console.WriteLine(SumOffOddPosition);