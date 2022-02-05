using System;

public class MainClass
{
    public static void Main()
    {
        Random rand = new Random();
        float a = rand.Next(1, 31);
        float b = rand.Next(1, 31);
        float c = a + b;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(a + b);
    }
}