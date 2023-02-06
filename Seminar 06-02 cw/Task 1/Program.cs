
// Задача 24: Напишите программу, которая на вход принимает число А и выдает сумму чисел от 1 до А.


Console.Write("Введите число А: ");

int numberA = int.Parse(Console.ReadLine());

if (numberA < 1)
{
    Console.WriteLine("Число меньше 1");
}
else
{
    int sum = 0;

    for (int i = 1; i <= numberA; i++)
    {
        sum += i;
    }
    Console.WriteLine($"sum = {sum}");
}

// Второй вариант

