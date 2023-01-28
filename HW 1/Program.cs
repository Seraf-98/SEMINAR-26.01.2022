// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine ("Введите первое число:");
string strNumber1 = Console.ReadLine();
int number1 = Convert.ToInt32(strNumber1); 
Console.WriteLine ("Введите второе число:");
string strNumber2 = Console.ReadLine();
int number2 = Convert.ToInt32(strNumber2); 

if (number1 > number2)
{
    Console.WriteLine(number1);
}
else {
    Console.WriteLine(number2); 
}






