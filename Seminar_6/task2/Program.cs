// переворот массива. функция swap. без создания доп.массива
// иниц (создание и заполнение массива)
// цикл фор хорошо подходит для массива тут
// i++ j-- len\2   или i и len-i
int[] arr = new int[] { 4, 5, 6, 3, 7, 9 };
void Swap(ref int a, ref int b)    // ref или xx&
{
    // Console.Write("Swap " + a + " " + b);
    int temp = a;
    a = b;
    b = temp;
}
for (int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
{
    Swap(ref arr[i], ref arr[j]);
    // int temp = arr[i];
    // arr[i] = arr[j];
    // arr[j] = temp;
}
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}