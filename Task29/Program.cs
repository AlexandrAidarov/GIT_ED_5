// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] array = CreateArray(8, 0, 10);
PrintArray(array);

int[] CreateArray(int size, int firstNum, int lastNum)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(firstNum, lastNum);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+ " ");
    }
    Console.Write("]");
}
