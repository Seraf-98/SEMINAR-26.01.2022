
/* 

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6

*/

Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine());

int Result = 0;

if (number > 100 && number < 1000)
{
    Result = number%100; // 675 -> 6.75 -> 75

    Result = Result%10; // 75 -> 7.5 -> 5

    System.Console.WriteLine(Result);
}
else if (number > 1000 && number < 10000)
{
    Result = number%100; // 3267 -> 32.67 -> 67

    Result = Result/10; // 67 -> 6.7 -> 6

    System.Console.WriteLine(Result);
}
else if (number > 10000 && number < 100000)
{
    Result = number%1000; // 32679 -> 32.679 -> 679

    Result = Result/100; // 679 -> 6.79 -> 6

    System.Console.WriteLine(Result);
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}

// Через проверку длинны строки

/*
Console.Write("Введите число: ");

int Number = Convert.ToInt32(Console.ReadLine());

string Text = Convert.ToString(Number); // перевод в строку

if (Text.Length > 2) // проверка длины строки
{
  Console.WriteLine(Text[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
}
*/
