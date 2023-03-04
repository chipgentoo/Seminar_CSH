//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write($"{inputMatrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[] AverageColumns(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    for (int i = 0; i < cols; i++)
    {
        double value = 0;
        for (int j = 0; j < rows; j++)
        {
            value = value + matrix[j, i];
        }
        average[i] = Math.Round(value / rows, 2);
    }
    return average;
}

Console.WriteLine("Исходный массив");
int[,] matrix = GetMatrix(3, 4);
PrintMatrix(matrix);
double[] average = AverageColumns(matrix);
Console.WriteLine();
Console.WriteLine($"{string.Join("\t", average)}");