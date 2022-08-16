// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// нельзя использовать pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int findSquare(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    return result;
}

System.Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень: ");
int B = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(findSquare(A, B));
