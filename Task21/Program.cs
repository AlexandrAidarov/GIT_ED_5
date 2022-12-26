// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84


Console.WriteLine("Введите координаты первой точки:");
Console.Write("X: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Z: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.Write("X: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Z: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);

Console.WriteLine(distance);

double Distance(double xa, double ya, double za, double xb, double yb, double zb)
{
    double result = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
    return result;
}


