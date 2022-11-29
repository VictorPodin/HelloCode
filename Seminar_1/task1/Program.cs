Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Поверяем является ли первое число квадратом второго");
if (number1 == number2*number2)
{
  Console.WriteLine("Да");  
}
else
{
  Console.WriteLine("Нет");  
}
