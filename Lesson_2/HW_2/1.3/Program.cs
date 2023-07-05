void Week(int num)
{
    string text = "Нет такого дня недели";

    if (num == 6 || num ==7) text = "Выходные";
    else if (num < 6 && num > 0) text = "Будни";

    Console.WriteLine($"{num} -> {text}");
}

int num = int.Parse(Console.ReadLine()!);
Week(num);