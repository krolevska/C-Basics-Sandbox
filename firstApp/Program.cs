using System;

namespace FuckingMatrixMultiplying
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,,,] bookshelves = new string[3, 5, 10, 10];

            bookshelves[0, 2, 3, 4] = "Adventures of Tom Soyer";
            bookshelves[1, 3, 4, 5] = "CLR via C#";
            bookshelves[2, 4, 5, 6] = "Brand New World";

            Console.Write("What book are you looking for? ");
            string request = Console.ReadLine();
            bool place = default;

            for (int r = 0; r < bookshelves.GetLength(0); r++)
            {
                for (int z = 0; z < bookshelves.GetLength(1); z++)
                {
                    for (int x = 0; x < bookshelves.GetLength(2); x++)
                    {
                        for (int y = 0; y < bookshelves.GetLength(3); y++)
                        {
                            if (bookshelves[r, z, x, y] == request)
                            {
                                place = true;
                                Console.Write($"Book is in room {r + 1} on the rack {z + 1}, shelf {x + 1}, place {y + 1}. ");
                                break;
                            }
                            else
                            {
                                ;

                            }
                        }
                    }
                }

            }
            if (place == false)
            {
                Console.Write($"I cannot find the book. Please try again. ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("We've got lots of books: ");
            for (int r = 0; r < bookshelves.GetLength(0); r++)
            {
                for (int z = 0; z < bookshelves.GetLength(1); z++)
                {
                    for (int x = 0; x < bookshelves.GetLength(2); x++)
                    {
                        for (int y = 0; y < bookshelves.GetLength(3); y++)
                        {
                            if (bookshelves[r, z, x, y] != null)
                            Console.WriteLine($"{bookshelves[r, z, x, y]} ");
                        }
                    }
                }
            }
        }
    }
}