/*
Задача 62.
Спиральное заполнение массива 4x4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

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
            Console.Write($"{inputMatrix[i, j]:d2} ");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Заполнение 2D массива по спирали
/// </summary>
/// <param name="rows">кол-во строк</param>
/// <param name="cols">кол-во колонок</param>
/// <returns>заполненный массив</returns>
int[,] SpiralMatrix(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    int padding = 0;    // смещение от края матрицы
    int idxRows = 0;    // текущая строка
    int idxCols = 0;    // текущий столбец
    int value = 1;      // начальное значение

    int cycle = rows > cols ? cols / 2 : rows / 2;

    while (cycle > 0)
    {
        idxRows = padding; idxCols = padding;
        for (idxCols = padding; idxCols < cols - 1 - padding; idxCols++)
        {
            array[idxRows, idxCols] = value; value++;
        }
        for (idxRows = padding; idxRows < rows - 1 - padding; idxRows++)
        {
            array[idxRows, idxCols] = value; value++;
        }
        for (idxCols = cols - 1 - padding; idxCols > padding; idxCols--)
        {
            array[idxRows, idxCols] = value; value++;
        }
        for (idxRows = rows - 1 - padding; idxRows > padding; idxRows--)
        {
            array[idxRows, idxCols] = value; value++;
        }
        padding++;
        cycle--;
    }
    return array;
}

// проверки
int[,] array ={{},{}};

Console.WriteLine("Массив 4х4");
array = SpiralMatrix(4, 4);
PrintMatrix(array);
Console.WriteLine();

Console.WriteLine("Массив 6х6");
array = SpiralMatrix(6, 6);
PrintMatrix(array);
Console.WriteLine();

Console.WriteLine("Массив 8х8");
array = SpiralMatrix(8, 8);
PrintMatrix(array);
Console.WriteLine();