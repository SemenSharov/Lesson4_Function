// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.WriteLine($"\nЗадача 25. Возведене числа A в натуральную степень B");

// int Exponentiation(int numberA, int numberB)
// {
//     int result = 1;
//     for (int i = 1; i <= numberB; i++)
//     {
//         result = result * numberA;
//     }
//     // int result = Math.Pow(numberA, numberB);
//     return result;
// }

int Exponentiation2(int a, int b)
{
    int r = a;
    for (int i = 2; i <= b; i++)
        r *= a;
    return r;
}



Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation2(a, b);
Console.WriteLine("Ответ: " + exponentiation);

