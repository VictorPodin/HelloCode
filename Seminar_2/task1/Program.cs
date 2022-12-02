// выводит случайное число от 10 до 99
// показывает какое число максимальное в составе этого двузначного числа
int n = new Random().Next(10,99);
int first = n / 10;
int second = n % 10;
Console.WriteLine("Выпало число: " +n);
if(first > second)
{
    Console.WriteLine("Большее цифра - " +first);
}
else
{
    Console.WriteLine("Большее цифра - " +second);
}