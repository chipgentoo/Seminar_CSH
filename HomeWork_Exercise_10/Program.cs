int checkNumber(string? strNumber)
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

Console.WriteLine("Вывод 2й цифры 3х-значного числа!!!");
Console.WriteLine("Ведите положительное целое число от 100 до 999");

int value = checkNumber(Console.ReadLine());
if (value >= 100 && value <= 999)
{
    int twoNumber = (value % 100) / 10;
    Console.Write($"Вторая цифра числа {value}: {twoNumber}");
}
else
{
    Console.WriteLine("Введены не верные данные!!!");
}
Console.WriteLine();