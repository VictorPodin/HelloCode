// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int GetLenghtOfNumber(int val)  // Количество цифр в числе
{
    int count = 0;
    while(val > 0)
    {
        val = val / 10;
        count++;
    }
    return count;
}
int lenght = GetLenghtOfNumber(N);
int[] digitsofnumber = new int[lenght]; 
for(int i = 0; i < lenght; i++)   //Заполнить цифрами массив
{
    digitsofnumber[i] = N % 10;
    N = N / 10;
}
int sum = 0;
for(int i = lenght - 1; i >= 0; i--)     //суммируем элементы массива и заодно выведем на экран
{
    sum = sum + digitsofnumber[i];
    Console.Write(digitsofnumber[i]);
}
Console.WriteLine(" -> " + sum);
