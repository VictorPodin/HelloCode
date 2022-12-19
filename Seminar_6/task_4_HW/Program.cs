// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых на плоскости,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//   значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Две прямые задаются уравнениями : y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите коэффициент b1");  // допустим что коэффициенты будут целочисленные...
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2");
int k2 = Convert.ToInt32(Console.ReadLine());
double x = 0, y = 0;
void GetCoordinatesOfCrossingPoint(int b1, int b2, int k1, int k2, ref double x, ref double y)  //попробовал по ссылке возвращать x y
{
    x = (double)(b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
}
if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны и не пересекаются");
}
else
{
    GetCoordinatesOfCrossingPoint(b1, b2, k1, k2, ref x, ref y);
    Console.WriteLine("точка пересечения: (" + x + "; " + y + ")");
}