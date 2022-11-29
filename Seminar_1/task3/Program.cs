/*
string[] DayOfWeek = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
Console.WriteLine("Введите число от 1 до 7");
int number1 = Convert.ToInt32(Console.ReadLine());
number1 = number1 - 1;
Console.WriteLine("Ваш день недели - ");
Console.WriteLine(DayOfWeek[number1]);
*/

Console.WriteLine("Введите число от 1 до 7");
int number1 = Convert.ToInt32(Console.ReadLine());
switch (number1)
{
    case 1: 
        Console.WriteLine("Понедельник");
        break;
    case 2: 
        Console.WriteLine("Вторник");
        break;
    case 3: 
        Console.WriteLine("Среда");
        break;
    case 4: 
        Console.WriteLine("Четверг");
        break;
    case 5: 
        Console.WriteLine("Пятница");
        break;
    case 6: 
        Console.WriteLine("Суббота");
        break;
    case 7: 
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("Чё, бухой?");
        break;
}