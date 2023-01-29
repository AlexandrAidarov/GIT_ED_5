// Задача 48
// Создаем  двумерный массив

int[,] CreateMatrixSumIndex(int rows, int coluums)
{
    int[,] matrix = new int[rows, coluums];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5}, ");
            else Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("]");
    }
}

int[,] matrixSumIndex = CreateMatrixSumIndex(3, 4);
PrintMatrix(matrixSumIndex);
