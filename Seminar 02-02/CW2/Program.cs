Console.Write ("Enter a number: ");
int num = int.Parse(Console.ReadLine());
int x = 1;
while (x <= num)
{
    Console.Write (x*x+ " ");
    x += 1;
}