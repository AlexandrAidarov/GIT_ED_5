// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7) Console.WriteLine("Такого дня недели нет!");
else
{
    Console.WriteLine(SquareNumber(number) ? "да" : "нет");
}

bool SquareNumber(int num1)
{
    return num1 % 6 == 0 || num1 % 7 == 0;
}

