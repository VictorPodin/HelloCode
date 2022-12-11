// Генерируем целочисленную переменную
int N = new Random().Next(1, int.MaxValue);
Console.WriteLine(N);
// Количество цифр в числе
int GetLenghtOfNumber(int val)
{
    int count = 0;
    while(val > 0)
    {
        val = val / 10;
        count++;
    }
    return count;
}
//Выделить память
int lenght = GetLenghtOfNumber(N);
//Заполнить цифрами
int[] digitsofnumber = new int[lenght];
for(int i = 0; i < lenght; i++)
{
    digitsofnumber[i] = N % 10;
    N = N / 10;
}
for(int i = lenght - 1; i >= 0; i--)
{
    Console.Write(digitsofnumber[i]);
}