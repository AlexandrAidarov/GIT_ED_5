// Задача 34
//Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


int[] CreateArrayRndInt (int size,  int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min,max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write(arr[i]+ ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int GetPositiveElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) sum += 1;
    }
    return sum;
}

// int GetsumNegativElem(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] < 0) sum += arr[i];
//     }
//     return sum;
// }

int[] array = CreateArrayRndInt(8, 100, 999);
PrintArray(array);
int sumPositive = GetPositiveElem(array);
// int sumNegativ = GetsumNegativElem(array);

Console.WriteLine($"Количество четных чисел в массиве = {sumPositive}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumNegativ}");
