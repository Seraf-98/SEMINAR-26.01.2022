﻿/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:

01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Console.Clear();

int n = 4;
int m = 4;
int[,] Matrix = new int[n, m];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= Matrix.GetLength(0) * Matrix.GetLength(1))
{
  Matrix[i, j] = temp;

  temp++;

  if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
    j++;

  else if (i < j && i + j >= Matrix.GetLength(0) - 1)
    i++;

  else if (i >= j && i + j > Matrix.GetLength(1) - 1)
    j--;

  else
    i--;
}

WriteArray(Matrix);

Console.WriteLine();

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)

      Console.Write($"0{array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
