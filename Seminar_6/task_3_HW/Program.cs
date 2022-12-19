// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Не использовать массив.
// M=5 ; 0, 7, 8, -2, -2 -> 2
// M=5 ; -1, -7, 567, 89, 223 -> 3
Console.WriteLine("Сколько чисел будем вводить?");
int M = Convert.ToInt32(Console.ReadLine());
int CountOfUserInputPositiveNumbers(int n)
{
    int Count = 0;
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("введите " + (i+1) + " число");
        int Number = Convert.ToInt32(Console.ReadLine());
        if (Number > 0)
        {
            Count++;
        }
    }
    return Count;
}
Console.WriteLine("Вы ввели " + CountOfUserInputPositiveNumbers(M) + " чисел больше 0");
