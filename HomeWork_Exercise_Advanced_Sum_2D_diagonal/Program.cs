// Сумма чисел по глвной диагонали 2х-мерного массива

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
    int cols = inputMatrix.GetLength(0);
    int rows = inputMatrix.GetLength(1);
    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            if (j == i) Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{inputMatrix[i, j]} ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int sumDiagonal(int[,] inputMatrix)
{
    int cols = inputMatrix.GetLength(0);
    int rows = inputMatrix.GetLength(1);
    int sum = 0;

    if (rows > 1 && cols > 1) // если 2х2 или больше
    {
        int count = 0;
        // ищем наименьший проход между строками и столбцами
        // чтобы не выйти за границы. (матрица прямоугольник)
        if (rows > cols)
        {
            count = cols;
        }
        else if (cols > rows)
        {
            count = rows;
        }
        else // rows = cols (матрица квадрат)
        {
            count = rows; // или cols (без разницы)
        }
        for (int i = 0; i < count; i++)
        {
            sum = sum + inputMatrix[i, i];
        }
    }
    else
    {
        return inputMatrix[0, 0]; // единственное значение (матрица 1х1) :-)
    }
    return sum;
}

int[,] matrix1 = GetMatrix(6, 5);
int sumDiag1 = sumDiagonal(matrix1);
PrintMatrix(matrix1);
Console.WriteLine($"Сумма чисел диагонали: {sumDiag1}");

int[,] matrix2 = GetMatrix(5, 6);
int sumDiag2 = sumDiagonal(matrix2);
PrintMatrix(matrix2);
Console.WriteLine($"Сумма чисел диагонали: {sumDiag2}");
