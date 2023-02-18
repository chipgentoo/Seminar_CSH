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
for (int i = 0; i < 10; i++)
{
    while (true)
    {
        int number = new Random().Next(10, 1000); // 10-999
        if(getMulti(number)==0) continue;
        if (getMulti(number) % getSum(number) == 0)
        {
            Console.WriteLine($"{i} число = {number}\t\t произв = {getMulti(number)}\t\t сумма = {getSum(number)}\t\t делитель = {getMulti(number) / getSum(number)}");
            arrayNumber[i] = number;
            break;
        }
    }
}