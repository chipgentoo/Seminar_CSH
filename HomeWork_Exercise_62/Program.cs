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
/// <param name="min">минимальное значение</param>
/// <param name="max">максимальное значение</param>
/// <returns>заполненный массив</returns>
int[,] SpiralMatrix(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    int spirals = 0; // счетчик круговых проходов
    int count = 0;   // кол-во затрагиваемых ячеек
    int value = 1;   // начальное значение заполнения
    int idxRows = 0; // указатель строки
    int idxCols = 0; // указатель колонки

    if (rows > cols) { spirals = cols / 2; } else { spirals = rows / 2; }

    for (int padding = 0; padding < spirals; padding++) // pading - отступ от внешнего края матрицы
    {

        // от края до предпоследнего для всех
        // по строке вправо.
        count = cols - 1 - padding;
        while (idxCols < count - padding)
        {
            array[idxRows + padding, idxCols + padding] = value;
            idxCols++;
            value++;
        }

        // по столбцу вниз
        count = rows - 1 - padding;
        while (idxRows < count - padding)
        {
            array[idxRows + padding, idxCols + padding] = value;
            idxRows++;
            value++;
        }

        // по строке влево
        count = cols - idxCols - 1 + padding;
        while (idxCols > count - padding)
        {
            array[idxRows - padding, idxCols - padding] = value;
            idxCols--;
            value++;
        }

        // по столбцу вверх
        count = rows - idxRows - 1 + padding;
        while (idxRows > count - padding)
        {
            array[idxRows - padding, idxCols - padding] = value;
            idxRows--;
            value++;
        }
    }
    return array;
}

// проверки
int[,] array = SpiralMatrix(5, 5, 10, 99);
PrintMatrix(array);