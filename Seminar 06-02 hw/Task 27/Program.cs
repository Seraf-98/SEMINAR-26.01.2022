/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

*/

int enterNum (string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int Sum (int Number)
{
    int res1 = 0;
    while (Number > 0)
    {
        res1 += Number % 10;
        Number = Number / 10;
    }
    return res1;
}

int Number = enterNum("Введите число: ");
Console.Write($"Ответ: {Sum(Number)}");
