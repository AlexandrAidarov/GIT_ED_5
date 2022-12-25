
Console.WriteLine("Введите координаты первой точки:");
Console.Write("X: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки:");
Console.Write("X: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double distance = Math.Round(Distance(x1, y1, x2, y2), 2, MidpointRounding.ToZero);

Console.WriteLine(distance);

double Distance(double xa, double ya, double xb, double yb)
{
    double result = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
    return result;
}

