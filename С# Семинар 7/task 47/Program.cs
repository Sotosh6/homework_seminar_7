// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

//     0   1   2    3

//0   0,5  7  -2  -0,2

//1   1  -3,3  8  -9,9

//2   8  7,8  -7,1  9


double[,] CreateMatrixRndDouble(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[rows, columns];  // 0, 1
    
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    { 
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(100) + rnd.NextDouble();
            matrix[i,j] = Math.Round(matrix[i,j], 1);
        }
    }
    return matrix;
} 

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j], 5} ");
    }
    Console.WriteLine("|");
    }
}

double[,] array2d = CreateMatrixRndDouble(3, 4, 1, 100);
PrintMatrix(array2d);