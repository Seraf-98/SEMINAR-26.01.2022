/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();

int numRows = SetNumber("строк");

int numColumns = SetNumber("столбцов");

int numMinValue = SetNumber("минимальное значение");

int numMaxValue = SetNumber("максимальное значение");

var matrix = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);
Print(matrix);

Console.WriteLine();

Console.Write($"Среднее арифметическое каждого столбца: ");

GetAvarage(matrix);

void GetAvarage(int[,] matrix)
{
    for (int l = 0; l < matrix.GetLength(1); l++)
    {
        double result = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            result += matrix[i,l];
        }
        Console.Write($"{Math.Round(result / matrix.GetLength(0), 1)};" + " ");
    }
    Console.WriteLine();
}

int SetNumber(string numberName)
{
    Console.Write($"Введите номер {numberName}: ");
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
