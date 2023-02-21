int GetNumberConsole(string message)
{
    Console.WriteLine(message);
    string strValue = Console.ReadLine()!;
    int number = int.Parse(strValue);
    return number;
}

int GetPower(int number, int exp)
{
    int value = 1;
    for (int i = 0; i < exp; i++)
    {
        value = value * number;
    }
    return value;
}

bool CheckExp(int exp)
{
    if (exp > 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int inNum = GetNumberConsole("Введите число: ");
int inExp = GetNumberConsole("Введите степень числа: ");

if (CheckExp(inExp))
{
    Console.WriteLine($"{inNum} в степени {inExp} = {GetPower(inNum, inExp)}");
}
else
{
    Console.WriteLine("Степень не должна быть отрицательной!");
}