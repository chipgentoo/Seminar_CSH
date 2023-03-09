/*
Задача 54:
Задать двумерный массив.
Упорядочить по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write($"{inputMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Сортировка строк двумерного массива целых чисел
/// </summary>
/// <param name="inputMatrix">Двумерный массив целых чисел</param>
/// <param name="sortType">
///     Принимает TRUE или FALSE для указания порядка сортировки
///     TRUE: по возрастанию (по умолчанию)
///     FALSE: по убыванию
/// </param>
/// <returns>Двумерный массив целых чисел сортированных построчно</returns>
int[,] SortRowsMatrix(int[,] inputMatrix, bool sortType = true)
{
    int rows = inputMatrix.GetLength(0);
    int cols = inputMatrix.GetLength(1);
    int tmp = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols - 1; j++)
        {
            for (int k = j + 1; k < cols; k++)
            {
                if (sortType)
                {
                    if (inputMatrix[i, j] > inputMatrix[i, k])
                    {
                        tmp = inputMatrix[i, j];
                        inputMatrix[i, j] = inputMatrix[i, k];
                        inputMatrix[i, k] = tmp;
                    }
                }
                else
                {
                    if (inputMatrix[i, j] < inputMatrix[i, k])
                    {
                        tmp = inputMatrix[i, j];
                        inputMatrix[i, j] = inputMatrix[i, k];
                        inputMatrix[i, k] = tmp;
                    }
                }
            }
        }
    }
    return inputMatrix;
}

// проверки.
int[,] array = GetMatrix(5, 5);
Console.WriteLine("\nИсходный массив:");
PrintMatrix(array);

int[,] sortDownArray = SortRowsMatrix(array); // по возрастанию
Console.WriteLine("\nОтсортированный по возрастанию массив:");
PrintMatrix(sortDownArray);

int[,] sortUpArray = SortRowsMatrix(array,false); // по убыванию
Console.WriteLine("\nОтсортированный по убыванию массив:");
PrintMatrix(sortUpArray);