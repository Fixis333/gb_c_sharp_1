void NumThird (int num)
{
    Console.Write($"{num} -> ");
    if (num < 100 )
    {
        Console.WriteLine("Третья цифра отсутствует");
        return;
    }
        while (num > 999) num /= 10;
        Console.WriteLine(num%10);
}

int num = int.Parse(Console.ReadLine()!);
NumThird (num);