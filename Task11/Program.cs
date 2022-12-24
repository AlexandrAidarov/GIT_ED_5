
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число => {number}");

int firdNumber = number % 10;
int firstNumber = number / 100;
int result = (firstNumber * 10) + firdNumber;

Console.WriteLine(result);