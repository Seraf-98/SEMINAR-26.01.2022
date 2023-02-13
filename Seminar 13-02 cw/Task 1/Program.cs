
int EnterNumber (string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int[] GetArray (int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue +1);
    }
    return res;
}

int size = EnterNumber("Введите длину массива: ");
int minValue = EnterNumber("Введите минимальное значение: ");
int maxValue = EnterNumber("Введите максимальное значение: ");
int result = 0;
Console.WriteLine();

int[] array = GetArray (size, minValue, maxValue);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine();

int[] ReversArray(int[] set)
{
    for (int i = 0; i < set.Length/2; i++)
    {
        int temp = set[i];
        set[i] = set [set.Length - 1 - i];
        set [set.Length - 1 - i] = temp;
    }
    return set;
}

Console.WriteLine(string.Join(" ", ReversArray(array)));
Console.WriteLine();
