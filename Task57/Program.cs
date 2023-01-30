// Задача 57: Составить частотный словарь элементов двухмерного массива.
// частотный словарь словарь содержит о ...
// 0 встречается 2 раза
// 1 встречается 1 раз и тд.


// Array.Sort(array2D);

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

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[temp] = matrix[i, j];
            temp++;
        }
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
int[] array = MatrixToArray(array2D);

Array.Sort(array);

int[] UniqElem(int[] arr)
{
    int count = 0;
    int[] arrayUniq = arr.Distinct().ToArray;
    int[,] arr2D = new int[arrayUniq.Length,1];

    int currentElem = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if()


    }
}
