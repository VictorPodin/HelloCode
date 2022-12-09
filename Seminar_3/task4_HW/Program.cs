// Напишите программу, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N. Полученный массив вывести на экран.
// 3 -> [1, 8, 27].
// 5 -> [1, 8, 27, 64, 125]
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count-1)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
    Console.Write(col[position]);
    Console.Write("]");
}
Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
for (int i = 0; i < N; i++)
{
    array[i] = Convert.ToInt32(Math.Pow(i+1,3));
}
PrintArray(array);