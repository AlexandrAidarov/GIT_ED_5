// кратно ли число 7 и 23
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 23 == 0 && number % 7 == 0)
{
    Console.WriteLine("Кратное.");
}
else
{
     Console.WriteLine("Не кратное");
}
