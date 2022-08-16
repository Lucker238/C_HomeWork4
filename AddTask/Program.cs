// Написать метод, который генерирует массив 0 и 1 заданного количества N
// 3 -> 1 1 0

// Написать метод, принимающий бинарное представление числа
// и возвращающее десятиченое представление числа
// 1 1 0 0 -> 12

// Написать метод, принимающий десятиченое представление и основание СС в которую нужно это число перевести, 2<= основание СС<= 9
// 10,2 -> 1010
// 10,8 -> 12

int[] makeBinArray(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

int fromBinToDeci(int[] array)
{
    int result = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        result += array[i] * (int)Math.Pow(2, length - 1 - i);
    }
    return result;
}

string changeSystem(int x, int y)
{
    string result = string.Empty;
    if (y >= 2 && y <= 9)
    {
        while (x > 0)
        {
            result = x % y + result;
            x /= y;
        }
        return result;
    }
    else return result = "Ошибка расчета, перезагрузите компьютер";
}



System.Console.Write("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = makeBinArray(N);
System.Console.Write("Введите основание системы счисления(от 2 до 9): ");
int Y = Convert.ToInt32(Console.ReadLine());
int X = fromBinToDeci(array);


System.Console.WriteLine($"[{string.Join(",", array)}] в десятичной системе равен: {X}");
System.Console.WriteLine($"{X} в {Y}-ной системе равен: {changeSystem(X, Y)}");





