// ввод и проверка на корректность числа
int getNumber()
{
    while (true)
    {
        Console.Write("Введите число >= 100: ");
        int number = 0;
        if (int.TryParse(Console.ReadLine(), out number))
        {
            // если число имеет не четную разрядность, больше 100 и меньше максимального целого (int)
            if (Convert.ToString(number).Length % 2 > 0 && number >= 100 && number <= int.MaxValue)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Требуется числовое значение нечетной разрядности >= 100!");
                continue;
            }
        }
        else
        {
            Console.WriteLine("Требуется целое (int) числовое значение!");
            continue;
        }
    }
}

// поиск максимальной цифры
int findMaxNumeric(int number)
{
    int maxNum = 0; // максимум ищем от самой маленькой цифры
    while (number > 0)
    {
        if (number % 10 > maxNum) maxNum = number % 10;
        number /= 10;
    }
    return maxNum;
}

// поиск минимальной цифры
int findMinNumeric(int number)
{
    int minNum = 9; // минимум ищем от самой большой цифры
    while (number > 0)
    {
        if (number % 10 < minNum) minNum = number % 10;
        number /= 10;
    }
    return minNum;
}

// поиск значения средней цифры
int findCentrNumber(int number)
{
    double centrNumber = 0;
    int digit = Convert.ToString(number).Length / 2;
    centrNumber = (number / Math.Pow(10, digit)) % 10;
    return (int)centrNumber;
}

Console.WriteLine("Поиск интересного числа среди чисел не четной разрядности");
int number = getNumber();
int minNumber = findMinNumeric(number);
int maxNumber = findMaxNumeric(number);
double centrNumber = findCentrNumber(number);

Console.Write($"min = {minNumber}\t center = {centrNumber}\t max = {maxNumber}\n");

if (maxNumber - minNumber == centrNumber)
{
    Console.WriteLine($"Число {number} очень интересное");
}
else
{
    Console.WriteLine($"Число {number} НЕ интересное");
}