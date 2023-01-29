// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void FindAnswer(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write("[");
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {

            if (i < matrix.GetLength(0) - 1) sum = matrix[i, j] + sum;
            else
            {
                sum = matrix[i, j] + sum;
                double average = Math.Round(sum / matrix.GetLength(0), 2, MidpointRounding.ToZero);
                Console.WriteLine(average);
            }

        }

    }
}


int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
FindAnswer(array2D);