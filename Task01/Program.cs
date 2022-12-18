
Console.Write("Введите первое целое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine($"Да, {number1} является квадратом числа {number2}");
}
else
 {
     Console.WriteLine($"Нет, {number1} не является квадратом числа {number2}");
 }
