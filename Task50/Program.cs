// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

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

Console.WriteLine("Введите номер строки:");
int numberRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца:");
int numberColum = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array);

if(numberRow < 1 && numberRow > 3 && numberColum < 1 && numberColum > 4)
{
    Console.WriteLine("такого элемента в массиве нет");
}
else
{
    Console.WriteLine($"значение этого элемента = {array[numberRow - 1, numberColum - 1]}");
}

