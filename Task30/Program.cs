// Задание №30
// Напишите программу которая выводит массив из 8 чисел и заполняет его 0 и 1.

int[] array = new int[8];

FillArray(array);
PrintArray(array);

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,2);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+ " ");
    }
}