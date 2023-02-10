Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Да, число " + number + " является четным");
}
else
{
    Console.WriteLine("Нет, число " + number + " НЕ является четным");
}