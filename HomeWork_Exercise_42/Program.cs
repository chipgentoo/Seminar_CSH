int GetNumberConsole(string message)
{
    int number = 0;
    Console.Write(message);
    string? strValue = Console.ReadLine();
    if (!int.TryParse(strValue, out number))
    {
        Console.WriteLine("Введите числовое значение!");
        Environment.Exit(-1);
    }
    return number;
}

int intValue = GetNumberConsole("Введите десятичное числовое значение: ");

string binLine = Convert.ToString(intValue, 2);
Console.WriteLine($"Бинарный формат числа {intValue} = 0x{binLine}");
