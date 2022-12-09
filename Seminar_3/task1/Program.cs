int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int[N];
for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(1,11);
}
int sum = 0;
float result = 0;
int count = 0;
for (int i = 0; i < N; i++)
{
    if (array[i] % 2 == 0)
    {
        sum = sum + array[i];
        count ++;
    }
}
result = (float)sum / count;
Console.WriteLine(result);