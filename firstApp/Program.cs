using System;

public class MainClass
{
    public static void Main()
    {
        string rana = Console.ReadLine();
        bool rama = bool.Parse(rana);
        if (rama == true)
        {
            Console.WriteLine("Попадание!");
        }
        
        else
        {
            Console.WriteLine("Промах!");
        }
    }
}