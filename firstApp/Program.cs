using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите число 1:");
        string a = Console.ReadLine();
        Console.WriteLine("Введите число 2:");
        string b = Console.ReadLine();
        int c = int.Parse(a);
        int d = int.Parse(b);
        bool e = ( c <= d );
        Console.WriteLine($"{c} меньше или равно {d} - {e}");
    }
}