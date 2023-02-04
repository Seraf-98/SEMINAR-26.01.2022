
/* 

Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/

Console.Write("Введите цифру, обозначающую день недели: ");

int DayNumber = int.Parse(Console.ReadLine());

if (DayNumber == 6 || DayNumber == 7)
{
    Console.WriteLine("Выходной");
}
else if (DayNumber < 1 || DayNumber > 7)
{
    Console.WriteLine("Это не день недели");
}
else Console.WriteLine("Будний день");
