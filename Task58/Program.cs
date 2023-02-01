/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


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


int[,] MatrixA = CreateMatrixRndInt(2, 3, 1, 5);
PrintMatrix(MatrixA);
Console.WriteLine();
int[,] MatrixB = CreateMatrixRndInt(3, 2, 1, 5);
PrintMatrix(MatrixB);

if (MatrixA.GetLength(1) == MatrixB.GetLength(0))
{
    Console.WriteLine();
    int[,] multiplyMatrix = MultiplyMatrix(MatrixA, MatrixB);
    PrintMatrix(multiplyMatrix);
}
else
{
    Console.WriteLine("Перемножение матриц не возможно");
}

int[,] MultiplyMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int countRow = 0;
            int countColum = 0;
            //int iA = i;
            while (countColum < matrixA.GetLength(1))
            {
                matrix[i, j] = matrix[i, j] + matrixA[i, countColum] * matrixB[countRow, j];
                countRow++;
                countColum++;
            }
        }
    }
    return matrix;
}



