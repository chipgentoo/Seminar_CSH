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

// этот массив вводится руками
int sizeArray = GetNumberConsole("Введите размер массива: ");
int[] array = new int[sizeArray];
for (int i = 0; i < sizeArray; i++)
{
    array[i] = GetNumberConsole($"Введите значение {i}-го элемента");
}
Console.WriteLine($"{string.Join("; ", array)}");

//этот массив - 8 случайных чисел
Console.WriteLine("Массив из 8 случайных чисел!");
int[] array2 = new int[8];
for (int i = 0; i < 8; i++)
{
    array2[i] = new Random().Next(10, 1000);
}
Console.WriteLine($"{string.Join("; ", array2)}");

