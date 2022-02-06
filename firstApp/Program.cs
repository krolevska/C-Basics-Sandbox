using System;

public class MainClass
{
    public static void Main()
    {
        for (int i = -100; i < 101; i++)
            {
                string stop = Console.ReadLine();
                Console.WriteLine("Для остановки введите 'exit':"); 
                if(stop == "exit")
                {
                    break;
                }
                Console.WriteLine(i);
             }
     }
}