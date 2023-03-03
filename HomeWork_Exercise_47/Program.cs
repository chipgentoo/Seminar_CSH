//  Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//  m = 3, n = 4.
//  0,5 7 -2 -0,2
//  1 -3,3 8 -9,9
//  8 7,8 -7,1 9

double[,] GetVoidRandMatrix(int min, int max)
{   // Generate 2D matrix random size from MIN to MAX
    int rows = 0, cols = 0;
    rows = new Random().Next(min, max + 1);
    cols = new Random().Next(min, max + 1);
    double[,] outputMatrix = new double[rows, cols];
    return outputMatrix;
}

void PrintMatrix(double[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write($"{inputMatrix[i, j]:f2}\t");
        }
        Console.WriteLine();
    }
}

double[,] FillMatrix(double[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            inputMatrix[i, j] = new Random().NextDouble() * new Random().Next(-100, 100);
        }
    }
    return inputMatrix;
}

//  Передаются MIN и MAX размеров!! матрицы.
double[,] matrix = GetVoidRandMatrix(2, 10);
matrix = FillMatrix(matrix);
PrintMatrix(matrix);