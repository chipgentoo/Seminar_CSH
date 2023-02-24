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

int evenNumberArray(int[] array)
{
    int size = array.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i]%2==0) count++;
    }
    return count;
}

int size = GetNumberConsole("Введите размер массива: ");
int[] array = new int[size];
int minValue = 100;
int maxValue = 999;
array = fillArray(array, minValue, maxValue);

Console.Write($"В массиве: [{string.Join("; ",array)}]\nкол-во четных чисел: {evenNumberArray(array)}\n");