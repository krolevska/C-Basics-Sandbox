using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите числа в диапазоне от 1 до 100.");
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        Console.WriteLine("1 число: " + first);
        Console.WriteLine("2 число: " + second);
        double a = double.Parse(first);
        double b = double.Parse(second);
        Console.WriteLine(a / b);
    }
}