// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2

Console.WriteLine("Сколько чисел вы будете вводить?");
int sizeOfArray = Convert.ToInt32(Console.ReadLine());


int[] array = CreateArrayInt(sizeOfArray);
int answer = GetNumbers(array);

PrintArray(array);
Console.WriteLine($"Вы ввели {answer} положительных чисел");

int GetNumbers(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result ++;
    }
    return result;
}

int[] CreateArrayInt(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число:");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}
