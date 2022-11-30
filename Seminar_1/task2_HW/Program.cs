Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Поверяем какое число больше:");
if (number1 == number2)
{
    Console.WriteLine("Оба числа одинаковые");  
}
else if (number1 > number2)
{
    Console.Write($"{"Первое число ("} {number1} ) больше");  
}
else if (number1 < number2)
{
    Console.Write($"{"Второе число ("} {number2} ) больше"); 
}