
Console.WriteLine("Введите номер четверти:");
string number = Console.ReadLine();

string result = Quarter(number);
Console.WriteLine(result);

string Quarter(string num)
{
    if (num == "1") return "x > 0 и y > 0";
    if (num == "2") return "x < 0 и y > 0";
    if (num == "3") return "x < 0 и y < 0";
    if (num == "4") return "x > 0 и y < 0";
    return "Не верно введена четверть.";
}
