
Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber % secondNumber == 0)
{
    Console.WriteLine("Кратное.");
}
else
{
     Console.WriteLine($"Не кратное, остаток - {firstNumber % secondNumber}");
}
