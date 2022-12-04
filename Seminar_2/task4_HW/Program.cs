// выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// если число двузначное, то третьей цифры не будет.
if (number >= 100)
{
    //чтобы остеить все ненужные цифры, будем делить число на 10, пока оно не станет меньше 1000
    while (number > 1000)
    {
        number = number / 10;
    }
    Console.Write("Третья цифра это: ");
    Console.Write(number%10);
}
else
{
Console.WriteLine("У вашего числа нет третьей цифры");
}
