using System;

namespace Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            int AB, BC, AC;
            Console.Write("AB = ");
            AB = Convert.ToInt32(Console.ReadLine());
            Console.Write("BC = ");
            BC = Convert.ToInt32(Console.ReadLine());
            Console.Write("AC = ");
            AC = Convert.ToInt32(Console.ReadLine());
            bool realABC = AB + BC >= AC && AC + BC >= AB && AC + AB >= BC;
            if (realABC)
            {
                Console.WriteLine("This is a triangle, thanks.");
                bool squareABC = AB * AB + BC * BC == AC * AC || AC * AC + BC * BC == AB * AB || AC * AC + AB * AB == BC * BC;
                bool evenABC = AB == AC && AB == BC && AC == BC;
                bool isoABC = AB == BC || AC == BC || AB == AC;
                if (squareABC)
                {
                    Console.WriteLine("Triangle is square.");
                }
                else if (evenABC)
                {
                    Console.WriteLine("Triangle is equilateral.");
                }
                else if (isoABC)
                {
                    Console.WriteLine("Triangle is isosceles.");
                }
                else
                {
                    Console.WriteLine("This triangle is nor square, neither equilateral, neather isosceles.");
                }
            }
            else
            {
                Console.WriteLine("This is not a triangle.");
            }
                        
        }
    }
 }