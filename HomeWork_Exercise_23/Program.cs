Console.WriteLine("Таблица кубов числа");

Console.Write("Введите число: ");
string? strNumber = Console.ReadLine();
int number;
if (int.TryParse(strNumber, out number))
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write($"Куб {i} = {Math.Pow(i,3)}\t\t");
        if (i%5==0)
        {
            Console.WriteLine(); // вывод в 5 столбцов
        }
    }
}
else
{
    Console.WriteLine("Это числовое значение!");
}
Console.WriteLine();