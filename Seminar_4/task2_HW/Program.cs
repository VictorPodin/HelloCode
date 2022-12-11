// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Не использовать функцию Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В какую степерь возведем? ");
int exponent = Convert.ToInt32(Console.ReadLine());
int result = number;
for(int i = 1; i < exponent; i++)
{
    result = result * number;
}
Console.WriteLine(number + ", " + exponent + " -> " + result);