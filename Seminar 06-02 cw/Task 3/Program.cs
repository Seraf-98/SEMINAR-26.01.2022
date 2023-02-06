
// Напишите программу, которая на вход принимает число N и выдает произведение чисел от 1 до N.

Console.Write("Введите число N: ");

int numberN = int.Parse(Console.ReadLine());

if (numberN < 1)
{
    Console.WriteLine("Число меньше 1");
}
else
{
    Console.WriteLine(result(numberN));
}

int result (int numberN)
{
    int prod = 1;

    for (int i = 1; i <= numberN; i++)
    {
        prod *= i;
    }

    return prod;
}