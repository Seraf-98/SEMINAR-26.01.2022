
/*
Задача 19.
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите пятизначное число: "); // 12821

int number = int.Parse(Console.ReadLine());


if (number>10000 && number<100000) 
{
    if (number/10000 == number%10 && (number/1000)%10 == (number%100)/10)
    {
        Console.WriteLine(number+ " является палиндромом");
    }
    else 
    {
        Console.WriteLine(number+ " не является палиндромом");
    }
}
else Console.WriteLine("Некорректное число");
