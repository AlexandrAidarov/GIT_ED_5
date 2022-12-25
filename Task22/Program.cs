
Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

TableSquare(number);

void TableSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count}     " + Math.Pow(count, 2));
        Console.WriteLine();
        count++;
    }

}