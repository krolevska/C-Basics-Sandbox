using System;

namespace FuckingMatrixMultiplying
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Напишите программу, в которой создайте два двумерных массива,
            //            по логике задачи реализующих математические матрицы.
            Console.WriteLine("Let us multiply two matrixes? ");
            decimal[,] arrayOne, arrayTwo;

            //            Размерность массивов получите от пользователя.
            //            Размерность массивов должна быть таковой, чтобы обеспечить возможность умножения этих матриц.
            //            На это ограничение нужно выполнить проверку.
            int linesArrayOne, columnsArrayOne, linesArrayTwo, columnsArrayTwo;

            Console.WriteLine("How many lines in first matrix? ");
            linesArrayOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many columns in first matrix? ");
            columnsArrayOne = Convert.ToInt32(Console.ReadLine());

            linesArrayTwo = 0;
            Console.WriteLine("How many lines in second matrix? ");
            linesArrayTwo = Convert.ToInt32(Console.ReadLine());

            while (linesArrayTwo != columnsArrayOne)
            {
                Console.WriteLine("Try again");
                linesArrayTwo = Convert.ToInt32(Console.ReadLine());
            }

            columnsArrayTwo = 0;
            Console.WriteLine("How many columns in second matrix? ");
            columnsArrayTwo = Convert.ToInt32(Console.ReadLine());

            //При прохождении проверки, заполните массивы данными, получая их от пользователя.
            arrayOne = new decimal[linesArrayOne, columnsArrayOne];
            arrayTwo = new decimal[linesArrayTwo, columnsArrayTwo];

            for (int i = 0; i < arrayOne.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOne.GetLength(1); j++)
                {
                    Console.WriteLine($"What is the {i + 1} number in the {j + 1} column in the first matrix? ");
                    arrayOne[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < arrayTwo.GetLength(0); i++)
            {
                for (int j = 0; j < arrayTwo.GetLength(1); j++)
                {
                    Console.WriteLine($"What is the {i + 1} number in the {j + 1} column in the second matrix? ");
                    arrayTwo[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //foreach (int i in arrayOne)
            //{
            //    Console.Write(i);
            //}

            //foreach (int j in arrayTwo)
            //{
            //    Console.Write(j);
            //}

            //Умножьте матрица
            decimal arraysMult = 0;
            for (int i = 0; i < arrayOne.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOne.GetLength(1); j++)
                {
                    for (int k = 0; k < arrayTwo.GetLength(1); k++)
                    {
                        arraysMult += arrayOne[i, j] * arrayTwo[j, k];
                    }
                }    
            }
            
            //Выведите на экран результат умножения матриц.
            Console.WriteLine($"The result is {arraysMult}. ");
        }
    }
}