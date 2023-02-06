
// Задача 26: Напишите программу, которая на вход принимает число и выдает количество цифр в числе.

Console.Write("Введите число А: ");

int number = int.Parse(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine("Число меньше 0");
}

int countNumbers (int num)
{
    int count = 0;

    for (; num > 0; count++)
    {
        num = num / 10;
    }

    return count;
}

Console.WriteLine($"Кол-во цифр = {countNumbers(number)}");
