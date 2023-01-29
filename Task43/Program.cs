// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.WriteLine("Введите число (k1)");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число (b1)");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число (k2)");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число (b2)");
double b2 = Convert.ToDouble(Console.ReadLine());

// y = k1 * x + b1, y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// (k1 - k2) * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны!");
}
else
{
    double x = SerchingAnswer(k1, b1, k2, b2);
    
    double y = k1 * x + b1;
    Console.WriteLine( $"Линии пересекаются в точке с коорддинатами {x},{y}");
}

double SerchingAnswer(double r1, double s1, double r2, double s2)
{
    double x1 = (s2 - s1) / (r1 - r2);
    return x1;
}

