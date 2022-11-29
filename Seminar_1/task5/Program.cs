// Console.WriteLine("Введите число ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int min = -number1;
// while (min <= number1)
// {
//     Console.Write(min);
//     if(number1 != min)
//     {
//     Console.Write(", ");
//     }
//     min = min + 1;
// }
Console.WriteLine("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());
for (int i = -number1; i != number1; i++)
{
    Console.Write(i);
    Console.Write(", ");
}
Console.Write(number1);