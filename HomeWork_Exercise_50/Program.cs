/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1(строчка) 7 (столбец) -> такого числа в массиве нет
*/

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

int FindValueFromPosition(string inPos, int[,] matrix)
{
    string[] position = inPos.Split(",");
    if (position.Length != 2)
    {
        Console.WriteLine("Не верное кол-во аргументов.");
        Environment.Exit(0);
    }
    int rows = Convert.ToInt32(position[0]);
    int cols = Convert.ToInt32(position[1]);

    if (cols > matrix.GetLength(0) || rows > matrix.GetLength(1))
    {
        Console.WriteLine($"Позиции {cols}, {rows} в матрице {matrix.GetLength(0)}, {matrix.GetLength(1)} не существует");
        Environment.Exit(0);
    }
    return matrix[rows - 1, cols - 1];
}

Console.Write("Введите позицию искомого числа в 2D матрице\nrow, col: ");
string strSource = Console.ReadLine()!;
if (string.IsNullOrEmpty(strSource))
{
    Console.WriteLine("Вы ни чего не ввели.");
    Environment.Exit(0);
}
int[,] matrix = GetMatrix(7, 7);
int outValue = FindValueFromPosition(strSource, matrix);
Console.WriteLine("Исходная матрица:");
PrintMatrix(matrix);
Console.WriteLine($"По заданной позиции в матрице найдено значение: {outValue}");
