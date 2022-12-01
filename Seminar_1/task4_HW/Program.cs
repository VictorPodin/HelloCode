Console.WriteLine("Введите три числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Поверяем какое число максимальное:");
int max = number1;
if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;  
}
Console.WriteLine(max);
