// Задача 66:
// Задать значения M и N.
// Найти сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/// <summary>
/// Ввод числа из терминала / консоли
/// </summary>
/// <param name="msg">Сообщение перед вводом</param>
/// <returns>Целое число</returns>
int InputNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

/// <summary>
/// Подсчет суммы чисел в промежутке от
/// </summary>
/// <param name="start">Начальное значение</param>
/// <param name="end">Конечное значение</param>
/// <returns>Сумму чисел</returns>
int GetSumNumbers(int start, int end)
{
    if (start == end) return end;
    if (start < end)
    {
        return (start + GetSumNumbers(start + 1, end));
    }
    else
    {
        return (start + GetSumNumbers(start - 1, end));
    }
}

// Проверка
Console.WriteLine(GetSumNumbers(InputNumber("Введите начальное число: "), InputNumber("Введите конечное число: ")));