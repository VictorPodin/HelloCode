// генерируем число
//создать массив размером равным количеству цифр getnumberlenght
// перебрать цифры
// при переборе проверяем цифры
void FillArrayWithDigits(int N, int[] arr)
{
    int i = 0;
    while(N > 0)
    {
        int digit = N % 10;
        if(digit % 2 == 0)
        {
            arr[i] = digit;
        }
        N = N / 10;
        i++;
    }

}
