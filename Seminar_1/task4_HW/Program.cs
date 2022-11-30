Console.WriteLine("Введите три числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Поверяем какое число максимальное:");
if ((number1 > number2) & (number1 > number3))
{
    Console.WriteLine(number1);  
}
else if ((number2 > number3) & (number2 > number1))
{
    Console.WriteLine(number2);  
}
else if ((number3 > number2) & (number3 > number1))
{
    Console.WriteLine(number3); 
}