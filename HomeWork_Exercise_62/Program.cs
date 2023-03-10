/*
Задача 62.
Спиральное заполнение массива.
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
            Console.Write($"{inputMatrix[i, j]:d2}\t");
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
    int spiral = 0;     // кол-во кольцевых проходов
    int padding = 0;    // смещение от края матрицы
    int value = 1;      // начальное значение заполнения
    int idxRows = 0;    // текущая строка
    int idxCols = 0;    // текущий столбец
    spiral = rows > cols ? cols / 2 : rows / 2;

    while (spiral > 0)
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
        spiral--;
    }
    return array;
}

// проверки
int[,] array = SpiralMatrix(10, 10);
PrintMatrix(array);