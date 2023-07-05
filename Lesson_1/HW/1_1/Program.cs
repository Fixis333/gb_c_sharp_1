Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);

if(a<b) {
    a = b;
}
if(a<c) {
    a = c;
}
Console.Write($"{a}");