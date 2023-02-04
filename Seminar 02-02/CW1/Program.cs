System.Console.Write ("Введите число X: ");

int numX = int.Parse (Console.ReadLine());

Console.Write ("Введите число Y: ");

int numY = int.Parse (Console.ReadLine());

if (numX > 0 && numY > 0)
{
    System.Console.WriteLine ("1 секция");
}
else if (numX < 0 && numY > 0)
{
    System.Console.WriteLine ("2 секция");
}
else if (numX < 0 && numY < 0)
{
    System.Console.WriteLine ("3 секция");
}
else if (numX > 0 && numY < 0)
{
    System.Console.WriteLine ("4 секция");
}
