// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArrayRndInt(int rows, int coluums, int min, int max)
{
    int[,] matrix = new int[rows, coluums];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLengthength(0); i++)
    {
        for (int j = 0; j < matrix.GetLengthength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

