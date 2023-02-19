/*
Задача 44: выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Если N = 5
--> 0 1 1 2 3
Если N = 3
--> 0 1 1
Если N = 7
--> 0 1 1 2 3 5 8
*/

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int[] fibonacci = new int[n];

int a0 = 0;
int a1 = 1;

fibonacci[0] = a0;
fibonacci[1] = a1;

for (int i = 2; i < n; i++)
{
    int a = a0 +a1;
    fibonacci[i] = a;

    a0 = a1;
    a1 = a;
}
foreach (int cur in fibonacci)
{
    Console.WriteLine(cur);
}

Console.WriteLine();
