int GetNumberConsole(string message)
{
    int number = 0;
    Console.WriteLine(message);
    string? strValue = Console.ReadLine();
    if (!int.TryParse(strValue, out number))
    {
        Console.WriteLine("Введите цифровое значение!");
        Environment.Exit(-1);
    }
    return number;
}

int[] fillArray(int[] array, int minValue, int maxValue)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int sumOddPasition(int[] array)
{
    int size = array.Length;
    int sum = 0;
    for (int i = 1; i < size; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int size = GetNumberConsole("Введите размер массива: ");
int[] array = new int[size];
int minValue = -999;
int maxValue = 999;
array = fillArray(array, minValue, maxValue);

Console.Write($"В массиве: [{string.Join("; ",array)}]\nсумма чисел нечетных позиций: {sumOddPasition(array)}\n");