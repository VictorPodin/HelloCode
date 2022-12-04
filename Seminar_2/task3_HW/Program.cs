// принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
// добавим проверку что число трехзначное
if (number <= 999 && number >= 100)
{
    Console.Write("Вторая цифра вашего числа = ");
    Console.WriteLine(number%100/10);
}
else
{
    Console.Write("Число не трехзначное!");
}