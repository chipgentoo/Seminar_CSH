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
    int prodSize = 0; // размер выходного массива
    if (inSize % 2 == 0)
    {
        prodSize = inSize / 2; // для четного размера массива
    }
    else
    {
        prodSize = inSize / 2 + 1; // для НЕ четного размера массива
    }
    
    int[] prodArray = new int[prodSize];
    for (int i = 0; i < prodSize; i++)
    {
        prodArray[i] = array[i] * array[(inSize - 1) - i];
    }
    
    return prodArray;
}

int size = GetNumberConsole("Введите размер массива: ");
int[] array = new int[size];
int minValue = 0;
int maxValue = 999;
array = fillArray(array, minValue, maxValue);
int[] prodArray = ProdArray(array);

Console.Write($"Исходный массив:[{string.Join("; ", array)}]\n");
Console.Write($"Массив произведений пар:[{string.Join("; ", ProdArray(array))}]\n");
