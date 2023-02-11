/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int [] array = GetArray (8, -10, 10);

Console.WriteLine(string.Join(" ", array));

int [] GetArray (int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue +1);
    }
    return res;
}

