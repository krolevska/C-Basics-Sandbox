using System;

namespace FuckingMatrixMultiplying
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,,] bookshelves = new string[5, 10, 10];

            bookshelves[2, 3, 4] = "Adventures of Tom Soyer";
            bookshelves[3, 4, 5] = "CLR via C#";
            bookshelves[4, 5, 6] = "Brand New World";

            Console.Write("What book are you looking for? ");
            string request = Console.ReadLine();
            bool place = default;

            for (int z = 0; z < bookshelves.GetLength(0); z++)
            {
                for (int x = 0; x < bookshelves.GetLength(1); x++)
                {
                    for (int y = 0; y < bookshelves.GetLength(2); y++)
                    {
                        if (bookshelves[z,x,y] == request)
                        {
                            place = true;
                            Console.Write($"Book is on the rack {z}, shelf {x}, place {y}. ");
                            break;
                        }
                        else
                        {
                            ;

                        }
                    }
                }
            }
            if (place == false)
            {
                Console.Write($"I cannot find the book. Please try again. ");
            }
        }
    }
}