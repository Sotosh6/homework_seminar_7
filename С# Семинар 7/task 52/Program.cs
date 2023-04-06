// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];  // 0, 1
    
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    { 
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
} 

void PrintMatrix(int[,] matrix)
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

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 100);
PrintMatrix(array2d);
for (int j = 0; j < array2d.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        sum += array2d[i, j];
        sum = Math.Round(sum, 1);
    }
    double result = sum / array2d.GetLength(0);
    double result1 = Math.Round(result, 1);
    Console.WriteLine($"Среднее арифметическое {j + 1}-ого столбца равно: {result1}");
}
