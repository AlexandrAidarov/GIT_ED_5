// 42 число пееписать в двоичный код

string res = ConvertDecToBin(2);
Console.WriteLine(res);

string ConvertDecToBin(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}
