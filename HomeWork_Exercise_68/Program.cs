// Задача 68:
// Даны два неотрицательных числа m и n.
// Вычисление функции Аккермана с помощью рекурсии.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Решение построено по псевдокоду
// взятому из википедии.

/// <summary>
/// Функция Аккермана
/// </summary>
/// <param name="numM"></param>
/// <param name="numN"></param>
/// <returns>Целое число</returns>
int GetAckerman(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    else if (numN == 0)
    {
        return GetAckerman(numM - 1, 1);
    }
    return GetAckerman(numM - 1, GetAckerman(numM, numN - 1));
}

// проверки
for (int i = 0; i <= 3; i++)
{
    for (int j = 0; j <= 5; j++)
    {
        Console.Write($"Ack({i}, {j})={GetAckerman(i, j)}\t");
    }
    Console.WriteLine();
}
