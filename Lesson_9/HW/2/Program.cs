int SumNumbers(int m, int n)
{
if (n < m) return 0;
return SumNumbers(m, n-1) + n;

}

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNumbers(M, N));