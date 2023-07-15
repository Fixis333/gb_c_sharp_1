Console.Write( "Введите  число" + " ");
int Number = int.Parse(Console.ReadLine()!);
 
int Sum = 0;

while (Number > 0)
{
    Sum = Sum + Number % 10;
    Number /= 10;
}
Console.WriteLine(Sum);