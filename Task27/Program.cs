// Задача 27: Напишите матод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int findNumbersSum(long N)
{
    long sum = 0;
    while(N > 0)
    {
        sum += N % 10;
        N /= 10;
    }
    return Convert.ToInt32(sum);
}

System.Console.Write("Введите число: ");
long A = Convert.ToInt64(Console.ReadLine());

System.Console.WriteLine(findNumbersSum(A));