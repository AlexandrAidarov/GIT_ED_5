/* Задача 68: Напишите программу вычисления функции Аккермана
 с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine("Введите первое число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int akkermanNum = AkkermanFunk(numberM, numberN);
Console.WriteLine(akkermanNum);

int AkkermanFunk(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    
    else if ((numM != 0) && (numN == 0))
    {
      return AkkermanFunk(numM - 1, 1);
    }
    else
    {
      return AkkermanFunk(numM - 1, AkkermanFunk(numM, numN - 1));
    }
}
