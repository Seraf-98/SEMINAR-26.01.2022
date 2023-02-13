
Console.WriteLine("Введите координату для точки А");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату для точки В");
int B = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату для точки С");
int C = int.Parse(Console.ReadLine());

bool IsTriangle(int A, int B, int C)
{
    return (((A+B)>C)&&((A+C)>B)&&((B+C)>A));
}

if (IsTriangle(A, B, C))
{
    Console.WriteLine("Может существовать");
}
else
{
    Console.WriteLine("Не может существовать");
}
