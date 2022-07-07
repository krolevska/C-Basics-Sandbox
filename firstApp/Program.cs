using System;

namespace FuckingMatrixMultiplying
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the text. ");

            string text = Console.ReadLine();

            string[][] words;

            string[] sentence = text.Split(".");

            words = new string[sentence.Length][];

            for (int i = 0; i < sentence.Length; i++)
            {
                words[i] = sentence[i].Split(" ");

                for (int j = 0; j < words[i].Length; j++)
                {
                    Console.WriteLine(words[i][j]);
                }
            }
        }
    }
}