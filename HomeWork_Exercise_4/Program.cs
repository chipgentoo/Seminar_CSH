Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1; // максимальное число - первое

if (number2 > max) // второе число больше максимального (первого)
{
    max = number2;
}

if (number3 > max) // третье число больше максимального (первого и второго)
{
    max = number3;
}

Console.WriteLine("Максимальное число: " + max);