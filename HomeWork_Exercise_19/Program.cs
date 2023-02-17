Console.Write("Введите 5ти-значное число: ");
string? strNumber = Console.ReadLine();
int number;
if (int.TryParse(strNumber, out number) && number > 9999 && number < 99999)
{
    //
    if (number / 10000 == number % 10 && (number / 1000) % 10 == (number % 100) / 10)
    {
        Console.WriteLine("Это полиндром 5ти-значного числа!");
    }
    else
    {
        Console.WriteLine("Это НЕ полиндром 5ти-значного числа!");
    }
}
else
{
    Console.WriteLine("Это НЕ 5ти-значное число!");
}