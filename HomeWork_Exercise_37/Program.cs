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

int[] ProdArray(int[] array)
{
    int inSize = array.Length;
    int outSize = inSize / 2;           // для четных массивов
    if (inSize % 2 != 0) outSize += 1;  // для НЕ четных массивов
    int[] outArray = new int[outSize];

    for (int i = 0; i < inSize / 2; i++)    // четные полностью, НЕ четные -1 значение
    {
        outArray[i] = array[i] * array[(inSize - 1) - i];
    }
    if (inSize % 2 != 0)    // для НЕ четных в конец добиваем среднее значение входящего массива
    {
        outArray[outSize - 1] = array[outSize-1];
    }
    return outArray;
}

int size = GetNumberConsole("Введите размер массива: ");
int[] array = new int[size];
int minValue = 0;
int maxValue = 999;
array = fillArray(array, minValue, maxValue);
int[] prodArray = ProdArray(array);

Console.Write($"Исходный массив:[{string.Join("; ", array)}]\n");
Console.Write($"Массив произведений пар:[{string.Join("; ", ProdArray(array))}]\n");
