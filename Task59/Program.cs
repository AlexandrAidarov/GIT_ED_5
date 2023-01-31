// Задача 59: Удалить строку и столбец на пересечении минимального числа в массиве

int[,] CreateMatrixRndInt(int rows, int coluums, int min, int max)
{
    int[,] matrix = new int[rows, coluums];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("]");
    }
}

int[] IndexMinVal(int[,] matrix)
{
    int min = matrix[0, 0];
    int IndexRow = 0;
    int IndexColum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                IndexRow = i;
                IndexColum = j;
            }
        }
    }
    return new int[] {IndexRow, IndexColum, min};
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2D);
int[] array = IndexMinVal(array2D);


PrintArray(array);
Console.WriteLine();
int[,] removedMatrix = RemoveMinRowCol(array2D, array[0], array[1]);
PrintMatrix(removedMatrix);

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+ " ");
    }
}

int[,] RemoveMinRowCol(int[,] matrix, int remRow, int remCol)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (i == remRow) m++;
        
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (j == remCol) n++;
        
            newMatrix[i, j] = matrix[m, n];
            n++;
        
        }
        m++;
        n = 0;
    }
    return newMatrix;
}
