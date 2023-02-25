/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.Clear();

int I = SetNumber("размер I");
int J = SetNumber("размер J");
int L = SetNumber("размер L");

int[,,] matrix = CubeMatrix(I, J, L);
Console.WriteLine();

Print3dMatrix(matrix);
Console.WriteLine();

int SetNumber(string numberName)
{
    Console.Write($"Введите {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void PutArray(int[] Num)
{
    int length = Num.Length;

    for (int i = 0; i < length; i++)
    {
        Num[i] = i + 10;
    }
    return;
}

int[] Shuffle(int[] sqr)
{
    Random odd = new Random();

    for (int i = sqr.Length - 1; i >= 1; i--)
    {
        int j = odd.Next(i + 1);

        int temp = sqr[j];
        sqr[j] = sqr[i];
        sqr[i] = temp;
    }
    return sqr;
}

int[,,] CubeMatrix(int numI, int numJ, int numL)
{
    int[,,] matrix = new int[numI, numJ, numL];

    if ((numI * numJ * numL) > 90) Console.WriteLine("Ошибка");
    int[] cube = new int[90];
    PutArray(cube);
    Shuffle(cube);

    for (int i = 0; i < numI * numJ * numL;)
    {
        for (int x = 0; x < numI; x++)
        {
            for (int y = 0; y < numJ; y++)
            {
                for (int z = 0; z < numL; z++)
                {
                    matrix[x, y, z] = cube[i];
                    i++;
                }

            }
        }
    }
    return matrix;
}


void Print3dMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
            {
                Console.Write($"{matrix[i, j, l]} ({j}, {l}, {i}) ");
            }
            Console.WriteLine();
        }
    }
}