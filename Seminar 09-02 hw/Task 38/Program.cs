/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] array = GetArray (5, 0, 10);

Console.WriteLine(string.Join(" ", array));

double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}

double diff = max - min;

/*
double MinMaxDiff(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return max - min;
}
*/

Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {diff}");

double[] GetArray (int size, int minValue, int maxValue)
{
    double[] result = new double[size];
    
    for (int i = 0; i < size; i++)
    {
        result[i] = Convert.ToDouble(new Random().Next(0, 100)/10.0);
    }
    return result;
}
