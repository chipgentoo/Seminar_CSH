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

int diffMinMax(int[] array)
{
    int size = array.Length;
    int min = array[0];
    int max = min;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return max - min;
}

int size = GetNumberConsole("Введите размер массива:");
int minValue = 0;
int maxValue = 1000;
int[] array = new int[size];
array = fillArray(array, minValue, maxValue);

Console.WriteLine($"В массиве: [{ string.Join("; ", array)}]\n\nразница между макс. и мин. значением состовляет: {diffMinMax(array)}");