/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int numbersSum = NumbersSum(numberOne, numberTwo);
Console.WriteLine(numbersSum);

int NumbersSum(int numOne, int numTwo)
{
     
    if (numOne < numTwo)
    {
        return numOne + NumbersSum(numOne + 1, numTwo);
    }
    else if (numOne > numTwo)
    {
        return numOne + NumbersSum(numOne - 1, numTwo);
    }
    else return numOne;
}

