/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

Console.Clear();

int numRows = SetNumber("строк");

int numColumns = SetNumber("столбцов");

int numMinValue = SetNumber("минимальное значение");

int numMaxValue = SetNumber("максимальное значение");

var matrix = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);
Print(matrix);
Console.WriteLine();

int RowIndex = SetNumber("строки");

int ColumnIndex = SetNumber("столбца");

if (RowIndex > matrix.GetLength(0) || ColumnIndex > matrix.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {RowIndex} строки и {ColumnIndex} столбца равно = {matrix[RowIndex-1,ColumnIndex-1]}");
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

