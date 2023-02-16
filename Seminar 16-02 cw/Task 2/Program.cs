
int numRows = SetNumber("Rows");

int numColumns = SetNumber("Columns");

int numMaxValue = SetNumber("Max Value");

int numMinValue = SetNumber("Min Value");

var matrix = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);
Print(matrix);

CheckValue(matrix);

Console.WriteLine();

Print(matrix);

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write(matrix[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}

void CheckValue(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            if (IsEven(i,l));
            {
                matrix[i,l] *= matrix[i,l];
            }
        }
    }
}

bool IsEven(int i, int l)
{
    return i % 2 == 0 && l % 2 == 0;
}

