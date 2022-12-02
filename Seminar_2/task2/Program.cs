Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Поверяем является ли одно число кратным второму:");
if (number1%number2 == 0)
{
  Console.WriteLine(number1 +" кратно " + number2);  
}
else if (number2%number1 == 0)
{
  Console.WriteLine(number2 +" кратно " + number1);  
}
else
{
    if (number1 > number2)
    {
       Console.WriteLine("Остаток от деления " + number1 +" на " + number2 + " = " + number1%number2); 
    }
    else
    {
        Console.WriteLine("Остаток от деления " + number2 +" на " + number1 + " = " + number2%number1);
    }
}