// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число :");

int SumNumder(string? str)

{
    int num = 0;

    foreach (char c in str)
    {
        num += c - '0';
    }
    return num;
}

Console.WriteLine(SumNumder(Convert.ToString(Console.ReadLine())));