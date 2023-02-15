long checkNumber(string? strNumber) // проверка на то, что это не строка
{
    long number = 0;
    try
    {
        return number = Convert.ToInt64(strNumber);
    }
    catch (System.Exception)
    {
        Console.WriteLine("Введенное значение не верно!");
        Environment.Exit(-1);
        return (-1);
    }
}

Console.WriteLine("Поиск N-й цифры для +/- Х-значного целого числа формата (long)");
Console.Write("Введите исходное число:");
long value = checkNumber(Console.ReadLine());

Console.Write($"Введите порядковый номер цифры до {Convert.ToString(value).Length} : ");
long ordinal = checkNumber(Console.ReadLine());

if (value < 0) value *= (-1); // инверсия знака

int digit = Convert.ToString(value).Length; // разрядность числа
if (ordinal > digit)
{
    Console.WriteLine($"{ordinal} цифры не существует");
    Environment.Exit(0);
}

long ordL = (value / Convert.ToInt64(Math.Pow(10, digit - ordinal))) % 10;  // левай цифра
long ordR = (value / Convert.ToInt64(Math.Pow(10, ordinal-1))) % 10;        // правая цифра
Console.WriteLine($"{ordinal} цифра слева = {ordL}\t {ordinal} цифра справа = {ordR}");