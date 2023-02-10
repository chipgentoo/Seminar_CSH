Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 0) n = n * (-1);

// Решение номер РАЗ - Цикл FOR от 2 до N через одну
for (int i = 2; i < n; i += 2)
{
    Console.Write(" " + i + " ");
}
Console.WriteLine();

// Решение номер ДВА - Цикл FOR с проверкой кождого числа
for (int i = 1; i < n; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(" " + i + " ");
    }
}
Console.WriteLine();

// Решение номер ТРИ - Цикл While с проверкой и счетчиком
int count = 1;
while (count < n)
{
    if (count % 2 == 0)
    {
        Console.Write(" " + count + " ");
    }
    count++;
}
Console.WriteLine();