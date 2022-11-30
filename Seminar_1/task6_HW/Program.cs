Console.WriteLine("Введите число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Проверим четное ли оно:");
if (number1 % 2 == 0)
{
    Console.WriteLine("Да, четное");
}
else
{
    Console.WriteLine("Нет, число нечётное");
}