Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int N = -number;
while (N <= number)
{
    Console.Write(N + " ");
    N++;
}

