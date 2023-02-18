// ввод и проверка на корректность числа
double getNumber(string Message)
{
    while (true)
    {
        Console.Write(Message);
        double number = 0.0;
        if (double.TryParse(Console.ReadLine(), out number) && number > 0)
        {
            return number;
        }
        else
        {
            Console.WriteLine("Требуется положительное числовое значение > 0!");
            continue;
        }
    }
}

double inValue = getNumber("Введите сумму вклада: ");

int percent = 0;
if (inValue > 200)
{
    percent = 10;
}
else if (inValue < 100)
{
    percent = 5;
}
else
{
    percent = 7;
}

Console.WriteLine($"По данному вкладу банк может предоставить Вам только {percent}% годовых");

double percentValue = inValue / 100 * percent;

Console.WriteLine($"что составит {percentValue:f2} у.е. за год");

double summa = inValue + (inValue / 100) * percent;

Console.WriteLine($"Через год Ваша сумма составит {summa:f2} у.е.");