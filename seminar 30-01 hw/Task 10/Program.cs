
/* 

Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/

Console.Write("Введите трёхзначное число: "); // 456

int number = int.Parse(Console.ReadLine());

int Result = 0;

if (number > 100 && number < 1000)
{
    Result = number%100; // 456 -> 4.56 -> 56

    Result = Result/10; // 56 -> 5.6 -> 5

    System.Console.WriteLine(Result);
}
else
{
    System.Console.WriteLine("Некорректное число");
}
