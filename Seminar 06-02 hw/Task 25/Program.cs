/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/
/*
Console.Write("Введите число А: ");

int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");

int numberB = int.Parse(Console.ReadLine());

if (numberB < 0)
{
    Console.WriteLine("Число B не должно быть меньше  меньше 0");
}
else
{
    int result = 1;

    for (int i = 0; i < numberB; i++)
    {
        result *= numberA;
    }
    Console.WriteLine($"Ответ = {result}");
}
*/

int enterNum (string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int Pow (int Base, int Exponent)
{
    int power = 1;

    for (int i = 0; i < Exponent; i++)
    {
        power *= Base;
    }
    return power;
}

bool ValidExponent (int Exponent)
{
    if (Exponent < 0)
    {
        Console.WriteLine("Второе число не должно быть меньше 0");
        return false;
    }
    return true;
}

int Base = enterNum("Введите основание: ");

int Exponent = enterNum("Введите экспоненту: ");

if (ValidExponent(Exponent))
{
    Console.WriteLine($"Ответ: {Pow(Base, Exponent)}");
}
