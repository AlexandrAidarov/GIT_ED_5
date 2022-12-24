
int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 => {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра => {firstDigit} ");
// else Console.WriteLine($"Наибольшая цифра => {secondDigit} ");

// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра => {maxDigit}");

int maxDigit2 = MaxDigit(78);
Console.WriteLine($"Наибольшая цифра => {maxDigit2}");

int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}
