Console.Write("Введите номер дня недели:");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine($"{number} - Понедельник");
}
else if (number == 2)
{
    Console.WriteLine($"{number} - Вторник");
}
else if (number == 3)
{
    Console.WriteLine($"{number} - Среда");
}
else if (number == 4)
{
    Console.WriteLine($"{number} - Четверг");
}
else if (number == 5)
{
    Console.WriteLine($"{number} - Пятница");
}
else if (number == 6)
{
    Console.WriteLine($"{number} - Суббота");
}
else if (number == 7)
{
    Console.WriteLine($"{number} - Воскресенье");
}
else 
{
    Console.WriteLine($"{number} - не корректное число");
}