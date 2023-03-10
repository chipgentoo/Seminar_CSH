using System.Diagnostics;

int getSum(int number)
{
    int summa = 0;
    while (number > 0)
    {
        summa = (number % 10) + summa;
        number /= 10;
    }
    return summa;
}

int getMulti(int number)
{
    int multi = 1;
    while (number > 0)
    {
        multi = (number % 10) * multi;
        number /= 10;
    }
    return multi;
}

Console.WriteLine("Массив из 10 интересных чисел произведение цифр которых делится на их сумму");
int[] arrayNumber = new int[10];
Stopwatch getTime = new Stopwatch();
getTime.Start(); // засекаем время
for (int i = 0; i < 10; i++)
{
    while (true)
    {
        int number = new Random().Next(10, 1000); // 10-999
        if(getMulti(number)==0) continue; // Ноль нет смысла делить.
        //if(getSum(number)==0) continue; // Сумма всегда > 0 если число > 0, а на ноль делить нельзя!!!
        if (getMulti(number) % getSum(number) == 0)
        {
            arrayNumber[i] = number;
            Console.WriteLine($"{i} число = {number}\t\t произв = {getMulti(number)}\t\t сумма = {getSum(number)}\t\t разность = {getMulti(number) / getSum(number)}");
            break;
        }
    }
}
getTime.Stop(); // останавливаем время
Console.WriteLine($"Затраченное время = {getTime.Elapsed}");