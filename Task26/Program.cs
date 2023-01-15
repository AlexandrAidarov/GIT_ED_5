// Задача №26: принимает число, выдает количество цифр в числе.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int numbers = Numbers(number);
Console.WriteLine($"В числе {number} : {numbers} цифр");

int Numbers(int num)
{
    int count = 1;
    while (num >= 10)
    {
        num = num / 10;
        count = count + 1;
    }
    return count;
}

