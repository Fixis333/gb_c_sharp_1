void OneAndTwo(int num)
{       
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine($"{num} -> yes");
    }
    else
    {
        Console.WriteLine($"{num} -> no");        
    }    
}

int result = int.Parse(Console.ReadLine()!);
OneAndTwo(result);