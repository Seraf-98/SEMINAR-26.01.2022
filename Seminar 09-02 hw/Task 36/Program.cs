/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] array = GetArray (6, -100, 100);

Console.WriteLine(string.Join(" ", array));

int sum = 0;

for (int i = 1; i < array.Length; i+=2)
{
    sum = sum + array[i];
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");

int[] GetArray (int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue +1);
    }
    return res;
}
