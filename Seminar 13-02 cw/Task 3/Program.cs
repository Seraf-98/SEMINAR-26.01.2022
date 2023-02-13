
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] NumbersConvert(int num)
{
    int size = 32;
    int[] Result = new int[size];
    for (int i = 0; i < size; i++)
    {
        Result[i] = num %2;
        num /=2;

    }
    return Result;
}

int[] Binary = (NumbersConvert(number));
Array.Reverse(Binary);
Console.WriteLine($"Полученный массив = "+ String.Join(", ", Binary));
