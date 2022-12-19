// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое целое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число:");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (max < number2 && number2 > number3)
{
    max = number2;
    Console.WriteLine($"Max - {max}");
}
else if (max < number3 && number3 > number2)
{
    max = number3;
    Console.WriteLine($"Max - {max}");
}
else
{
    Console.WriteLine($"Max - {max}");
}
