/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();

int numRows = SetNumber("количество строк");

int numColumns = SetNumber("количество столбцов");

int numMinValue = SetNumber("минимальное значение");

int numMaxValue = SetNumber("максимальное значение");

var matrix = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);
Print(matrix);
Console.WriteLine();
Console.WriteLine($"Индекс строки с минимальной суммой = {MinRowSum(matrix)}");
Console.WriteLine();


int SetNumber(string numberName)
{
    Console.Write($"Введите {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void Print(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write(matrix[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}

int MinRowSum(int[,] matrix)  //  Метод нахождения строки с минимальной суммой элементов
{
    int Row = 0;
    int? Min = null;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int Sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Sum = Sum + matrix[i, j];
        }
        if (Min == null) Min = Sum;
        else if (Sum < Min)
        {
            Min = Sum;
            Row = i;
        }
    }
    return Row;
}