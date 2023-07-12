Console.WriteLine("Введите пятизначное число ");
string N = Console.ReadLine()!;
int Len = N.Length;

if (Len == 5)
{
    if (N[0] == N[4] && N[1] == N[3])
    {
        Console.WriteLine($"{N} - Ура! Палиндром");
    }
    else
    {
        Console.WriteLine($"{N} - Увы! Не палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {N} - не является пятизначным");
}