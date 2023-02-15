int checkNumber(string? strNumber) // проверка на то, что это не строка
{
    int number = 0;
    try
    {
        return number = Convert.ToInt32(strNumber);
    }
    catch (System.Exception)
    {
        return number = (-1);
    }
}

Console.WriteLine("Поиск 3й цифры для +/- 7ми-значного числа");
Console.WriteLine("Введите число:");

int value = checkNumber(Console.ReadLine());

if (value >= -9999999 || value <= 9999999)
{
    if (value < 0) value *= (-1); // инверсия знака
    string strNumber = Convert.ToString(value); // пределяем длинну числа
    int digit = strNumber.Length;               // для определения разрядности/порядка
    if (digit > 2) // если 3х-значное или больше
    {
        double tmp = 0;
        while ((value % (10 ^ digit)) > 1)
        {
            Console.WriteLine($"value = {value}\tdigit = {digit}\ttmp = {tmp}");
            tmp = value % (10 ^ digit);
            digit++;
        }
    }
}
