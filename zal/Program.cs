int size = 123;
int[] array = GetArray(size);

int[] GetArray(int size)
{
    int[] rndArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        rndArray[i] = new Random().Next(0, 500);
    }
    return rndArray;
}

int countArray(int[] array, int minValue, int maxValue)
{
    int sizeArray = array.Length;
    int count = 0;
    
    for (int i = 0; i < sizeArray; i++)
    {
        if (array[i] >= minValue && array[i] <= maxValue)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine($"Исходный массив: [ {string.Join("; ", array)} ]\n\n");
Console.WriteLine($"Кол-во элементов: { countArray(array, 10, 99)}");