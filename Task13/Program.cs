// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. Выполнить с помощью числовых операций 
//(целочисленное деление, остаток от деления).
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

// if (number < 0) number = -number;

if (number > 99)
{
    while (number > 999)
    {
        number = number / 10;
    }

    int firdNumber = number % 10;
    Console.WriteLine($"Третья цифра => {firdNumber}");
}
else if (number < -99)
{
    while (number < -999)
    {
        number = number / 10;
    }

    int firdNumber = number % 10 * -1;
    Console.WriteLine($"Третья цифра => {firdNumber}");
}
else
{
    Console.WriteLine("Третьего числа нет.");
}

