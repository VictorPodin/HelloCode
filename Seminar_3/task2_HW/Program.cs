// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
// number / 10000  первое число
// number % 10  последнее число
// number / 1000 % 10 второе число
// number % 100 / 10  предпоследнее число
if (number <= 99999 && number >= 10000)
{
     if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10)
     {
     Console.WriteLine("Палиндром!");
     }
     else
     {
        Console.WriteLine("Сожалею, но это не палиндром");
     }
}
else
{
    Console.WriteLine("Нам надо только пятизначное число!!!");
}