int GetNumberConsole(string message)
{
    Console.WriteLine(message);
    string? strValue = Console.ReadLine();
    int number = Convert.ToInt32(strValue);
    return number;
}

int value = GetNumberConsole("Введите число: ");
if (value < 0) value *= (-1);
int sum = 0;
while (value > 0)
{
    sum += value % 10;
    value /= 10;
}
Console.WriteLine($"Сумма цифр равна {sum}");