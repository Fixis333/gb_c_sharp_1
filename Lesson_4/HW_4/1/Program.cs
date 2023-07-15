Console.Write( "Введите a ");
int a = int.Parse(Console.ReadLine()!);
Console.Write( "Введите b ");
int b = int.Parse(Console.ReadLine()!);;
int step = 1;
for (int i = 1; i <= b; i++)
    step = step * a;
    Console.WriteLine($"Число {a} в степени {b} равно {step}");
