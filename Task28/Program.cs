// Задача №28: принимает число N, выдает произведение чисел от 1 до N.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int numbers = Numbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {numbers}");

int Numbers(int num)
{
    int count = 1;
    int digit = 1;
    while (count <= num)
    {
        digit = digit * count;
        count = count + 1;
    }
    return digit;
}
