Console.Write("Введите число ");
int a = int.Parse(Console.ReadLine()!);
int count = 1;
if (a == 0)
{
    Console.WriteLine("1");
}
else if (a > 0)
{
    while (count <= a)
    {
        Console.WriteLine(Math.Pow(count, 2));
        count++;
    }
}
