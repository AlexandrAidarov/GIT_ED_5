// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int n = 2;
while (number >= n)
{
    Console.Write(n + " ");
    n = n + 2;
}