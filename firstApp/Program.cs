using System;

namespace FuckingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Выведите на экран консоли все числа от 0 до 100;
            for (int a = 0; a <= 100; a++)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine("");
            //2.Выведите на экран числа от 1001 до 2500 с шагом – 3;
            for (int b = 1001; b <= 2500; b += 3)
            {
                Console.Write(b + " ");
            }
            //3.Выведите числа от 100 до 0 с шагом – 4;
            Console.WriteLine("");
            for (int c = 100; c >= 0; c -=4)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine("");
            //4.Выведите числа от 1 до 5 с шагом 0,2.
            for (double d = 1; d <= 5; d +=0.2)
            {
                Console.Write(d + " ");
            }
        }
    }
}