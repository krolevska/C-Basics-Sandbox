using System;

public class MainClass
{
    public static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        string third = Console.ReadLine();
        string fourth = Console.ReadLine();
        float a = float.Parse(first);
        float b = float.Parse(second);  
        float c = float.Parse(third);
        float d = float.Parse(fourth);
        Console.WriteLine((b + d) / a + c);
    }
}