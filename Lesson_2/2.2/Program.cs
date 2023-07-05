  void OneOfNum(int num_1, int num_2)
{       
    if (num_1 % num_2 == 0)
    {
        Console.WriteLine($"{num_1}, {num_2} -> multiple");
    }
    else
    {
        Console.WriteLine($"{num_1}, {num_2} -> not multiple, the remainder {num_1 % num_2}");        
    }    
}

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
OneOfNum(a, b);