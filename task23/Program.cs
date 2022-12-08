//Напишите программу, которая на вход принимает число (N) и выдает таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число N");
double N = double.Parse(Console.ReadLine()!);

if (N < 0)
{
   for (int i = -1; i >= N; i--)
    {
        double ThirdDegree = Math.Pow(i, 3);
        Console.WriteLine(ThirdDegree);
    } 
}
else if (N == 0)
{
    double ThirdDegree = 0;
    Console.WriteLine(ThirdDegree);
}
else
{
    for (int i = 1; i <= N; i++)
    {
        double ThirdDegree = Math.Pow(i, 3);
        Console.WriteLine(ThirdDegree);
    }
}