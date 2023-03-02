/*  Задача 43:
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями:
y = k1 * x + b1
y = k2 * x + b2
Значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
//=============================================================================
//  Подсказанное решение
//  X = (b2 - b1) / (k1 - k2)
//  Y = k1 * X + b1
//=============================================================================

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

double b1 = GetNumberConsole("Введите значение b1: ");
double k1 = GetNumberConsole("Введите значение k1: ");
double b2 = GetNumberConsole("Введите значение b2: ");
double k2 = GetNumberConsole("Введите значение k2: ");

double x = 0, y = 0;

if ((k1 != k2))
{
    //b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    x = (b2 - b1) / (k1 - k2);  // (4 - 2) / (5 - 9) = 2 / -4 = -0.5
    y = k1 * x + b1;            // 5 * -0.5 + b1 = -2.5 + 2 = -0.5
}
else
{
    Console.WriteLine("Решение отсутствует");
}

Console.WriteLine($"Точка пересечения x = {x}; y = {y};");