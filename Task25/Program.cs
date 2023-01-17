// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B

Console.WriteLine("Введите первое целое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 > 0)
{
    int sumNumbers = SumNumbers(number1, number2);
    Console.WriteLine($"Число {number1} в степени {number2} = {sumNumbers}");
}
else
{
    Console.WriteLine("Введены не корректные данные!");
}

int SumNumbers(int num1, int num2)
{
    int answer = 1;
    for (int i = 1; i <= num2; i++)
    {
        answer = answer * num1;
    }
    return answer;
}

