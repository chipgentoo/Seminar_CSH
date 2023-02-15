int checkNumber(string? strNumber) // проверка на то, что это не строка
{
    int number = 0;
    try
    {
        return number = Convert.ToInt32(strNumber);
    }
    catch (System.Exception)
    {
        return (-1);
    }
}

Console.WriteLine("Введите номер дня недели (1-7)");

int numDay = checkNumber(Console.ReadLine());
if (numDay > 0 && numDay < 8)
{
    if (numDay == 6 || numDay == 7)
    {
        Console.WriteLine("Это выходной день");
    }
    else
    {
        Console.WriteLine("Это рабочий день");
    }
}
else
{
    Console.WriteLine("Не корректный номер дня недели");
}