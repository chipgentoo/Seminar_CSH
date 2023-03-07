/*
Задача 56:
Задать прямоугольный двумерный массив.
Найти строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

/// <summary>
/// Генератор двумерного массива целых двузначных чисел
/// </summary>
/// <param name="rows">кол-во строк</param>
/// <param name="cols">кол-во столбцов</param>
/// <returns>Двумерный массив заполненный рандомными целыми двузначными числами (10-99)</returns>
int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(10, 100); // [10,99]
        }
    }
    return matrix;
}

/// <summary>
/// Печать двумерного массива целых чисел
/// </summary>
/// <param name="inputMatrix">Двумерный массив целых чисел</param>
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        Console.Write($"{i+1}\t");
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write($"{inputMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Поиск в двумерном массиве целых чисел строки с наименьшей суммой
/// </summary>
/// <param name="inputMatrix">Двумерный массив целых чисел</param>
/// <returns>номер строки</returns>
int RowSmallestSum(int[,] inputMatrix)
{
    int rows = inputMatrix.GetLength(0);
    int cols = inputMatrix.GetLength(1);
    int rowMin = int.MaxValue;  // ИД строки с минимальной суммой
    int prevSum = int.MaxValue; // предыдущая сумма
    int currSum = int.MinValue; // текущая сумма

    for (int i = 0; i < rows; i++)
    {
        currSum = 0;
        for (int j = 0; j < cols; j++)
        {
            currSum += inputMatrix[i, j];
        }
        if (currSum < prevSum)
        {
            prevSum = currSum;
            rowMin = i;
        }
    }
    return rowMin;
}

// проверки
int[,] array = GetMatrix(4, 4);
System.Console.WriteLine("Исходный массив:");
PrintMatrix(array);
int rowMin = RowSmallestSum(array);
System.Console.WriteLine($"Строка с наименьшей суммой: {rowMin + 1}");
