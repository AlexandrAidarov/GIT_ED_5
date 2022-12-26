// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number <100000)
{
    Console.WriteLine(Unswer(number) ? "да" : "нет");
}
else
{
    Console.WriteLine("Введено не корректное число.");
}

bool Unswer(int num)
{
    return num / 10000 == num % 10 && (num / 1000) % 10 == (num % 100) / 10;
}
