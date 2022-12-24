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

// Connsole.WriteLine(BothMultiple(number) ? "да" : "нет");
// bool BothMultiple(int num, int num1 = 7, int num2 = 23)
// {
//     return num % num1 == 0 && num % num2 == 0;
// }