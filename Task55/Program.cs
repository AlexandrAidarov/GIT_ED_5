// Задача 56: Задайте двумерный массив. Напишите программу, которая
// заменяет строки на столбцы

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5}, ");
            else Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2D);
if (array2D.GetLength(0) == array2D.GetLength(1))
{    
    // int[,] newArray2D = ChangeMatrixInt(array2D);
    // PrintMatrix(newArray2D);
    ChangeMatrixInt(array2D);
    Console.WriteLine();
    PrintMatrix(array2D);
}
else Console.WriteLine("Количество строк и столбцов не равно. Операция не возможна!");


// int[,] ChangeMatrixInt(int[,] matrix)
// {
//     int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             newMatrix[i, j] = matrix[j, i];
//         }
//     }
//     return newMatrix;
// }

void ChangeMatrixInt(int[,] matrix)
{
        
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {

        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}
