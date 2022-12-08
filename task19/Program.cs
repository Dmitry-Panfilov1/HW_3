Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine()!);

if (number < 0)
{
    number = Math.Abs(number);
}

if (number > 99999 || number < 10000)
{
    Console.WriteLine("Введенное число не является пятизначным");
}

else
{
    int[] array = {0, 0, 0, 0, 0};

    for (int i = 0; i < 5; i++)
    {
        array[i] = number % 10;
        number = number / 10; 
    }

    if (array[0] == array[4] && array[1] == array[3])
    {
        Console.WriteLine("ДА");
    }
    else
    {
        Console.WriteLine("НЕТ");
    }
}