/* Задача 58: Задайте значения M и N. Напишите программу которая выведет
все натуральные числа от M до N

*/

Console.WriteLine("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

NumbersRange(numberOne, numberTwo);

void NumbersRange(int numOne, int numTwo)
{
    if (numOne == numTwo) Console.Write($"{numOne} ");
    else if (numOne < numTwo)
    {
        Console.Write($"{numOne} ");
        NumbersRange(numOne + 1, numTwo);
    }
    else
    {
        Console.Write($"{numOne} ");
        NumbersRange(numOne - 1, numTwo);
    }
   
}
