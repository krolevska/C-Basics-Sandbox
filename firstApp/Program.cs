using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Законодательство США допускало отправку детей по почте до 1913 года");
        Console.WriteLine("Ответь на данный факт true или false");
        var b = Console.ReadLine();
        Convert.ToBoolean(b);
        Console.WriteLine($"Ответ:{ b}");

    }
}