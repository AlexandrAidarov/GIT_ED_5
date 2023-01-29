// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка



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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5}, ");
            else Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2D);
SerchingLess(array2D);

void SerchingLess(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1)) arr[i] = arr[i] + matrix[i, j];
            // else arr[i] = sum;
        }
    }
    // Console.Write("(");
    // for (int i = 0; i < arr.Length; i++)
    // {
    //     if(i < arr.Length - 1) Console.Write($"{arr[i], 5}, ");
    //     else Console.Write($"{arr[i], 5} ");
    // }
    // Console.WriteLine(")");
    
    int numberRow = 0;
    int minRow = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <= minRow) 
        {
            minRow = arr[i];
            numberRow = i + 1;
        }
    }
    Console.WriteLine($"{numberRow} строка");
}
