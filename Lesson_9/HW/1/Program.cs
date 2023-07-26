    void EvenNumbersMtoN(int m, int n)
    {
    if (n < m) return;

    EvenNumbersMtoN(m, n - 2);
    Console.Write($"{n}, ");
    }

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N % 2 == 0)
{
    EvenNumbersMtoN(M, N);
}
else
{
    EvenNumbersMtoN(M, N - 1);
}