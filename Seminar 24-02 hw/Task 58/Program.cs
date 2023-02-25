/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:

2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:

18 20
15 18

*/

Console.Clear();

Console.WriteLine("Первая матрица:");

int numRows1 = SetNumber("количество строк");

int numColumns1 = SetNumber("количество столбцов");

int numMinValue1 = SetNumber("минимальное значение");

int numMaxValue1 = SetNumber("максимальное значение");

var matrix1 = GetMatrix(numRows1, numColumns1, numMinValue1, numMaxValue1);

Console.WriteLine();

Console.WriteLine("Вторая матрица:");

int numRows2 = SetNumber("количество строк");

int numColumns2 = SetNumber("количество столбцов");

int numMinValue2 = SetNumber("минимальное значение");

int numMaxValue2 = SetNumber("максимальное значение");

var matrix2 = GetMatrix(numRows2, numColumns2, numMinValue2, numMaxValue2);

Print(matrix1);
Print(matrix2);

if (matrix1.GetLength(1) != matrix2.GetLength(0)) Console.WriteLine("Матрицы не умножаются");
else Print(ProductMatrix(matrix1, matrix2));
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
            Console.Write(matrix[i, l] + " ");
        }
        Console.WriteLine();
    }
}

int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)  //  Метод для умножения матриц
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int l = 0; l < matrix2.GetLength(0); l++)
            {
                resultMatrix[i, j] += matrix1[i, l] * matrix2[l, j];
            }
        }
    }
    return resultMatrix;
}