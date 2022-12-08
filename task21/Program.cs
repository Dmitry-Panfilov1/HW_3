// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координату Х точки А");
double x1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y точки А");
double y1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z точки А");
double z1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Х точки В");
double x2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y точки В");
double y2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z точки В");
double z2 = double.Parse(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine(distance);