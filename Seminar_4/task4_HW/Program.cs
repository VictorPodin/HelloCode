// Назовём число «интересным» если его произведение цифр делится на их сумму.
// Напишите программу, которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000.
// (каждый эл-т массива – сгенерирован случайно)
// [591, 532, 189, 523, 333, 546, 527, 275, 456, 264]
int GetLenghtOfNumber(int val)  //функция чтобы брать длину выпавшего числа
{
    int count = 0;
    while(val > 0)
    {
        val = val / 10;
        count++;
    }
    return count;
}   
bool CheckNumberForInteresting(int Num)  //Функция проверки числа на интересность
{
    int sum = 0;
    int prod = 1;
    int lenght = GetLenghtOfNumber(Num);
    int[] digitsofnumber = new int[lenght];    //инициируем массив под число
    for(int i = 0; i < lenght; i++)            //заполняем его цифрами числа
    {
        digitsofnumber[i] = Num % 10;
        Num = Num / 10;
    }
    for(int i = 0; i < lenght; i++)             //считаем сумму и произведение цифр в числе
    {
        sum = sum + digitsofnumber[i];
        prod = prod * digitsofnumber[i];
    }
    if (prod % sum == 0 && prod != 0)          // prod != 0 исключит числа в составе которых 0, их произведение = 0...
    {
        return true;
    }
    else
    {
        return false;
    }
}
void PrintArray(int[] col) // Просто вывод  массива в красивом формате
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count-1)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
    Console.Write(col[position]+ "]");
}
//Сделали нужные функции, теперть к задаче
int[] array = new int[10];
int i = 0;
while (i < 10)
{
    int number = new Random().Next(10, 1001);  //генерим число
    if (CheckNumberForInteresting(number) == true)
    {
        array[i] = number;
        i++;
    }
}
PrintArray(array);