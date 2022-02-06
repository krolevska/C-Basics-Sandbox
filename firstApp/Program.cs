using System;

namespace Learning
{ 
public class MainClass
{
    public static void Main()
    {
        char input = char.Parse(Console.ReadLine());
        switch (input)
            {
            case '1':
                Console.WriteLine("Персонаж применяет аптечку");
                break;
            case '2':
                Console.WriteLine("Персонаж пьет зелье");
                break;
            case 'e':
                Console.WriteLine("Персонаж открывает дверь");
                break;
                }
        }

    }
}