using System;

namespace FuckingArray
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. получите от пользователя целое число.
            Console.Write("How big is the array? ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            
            //2. Создайте массив целочисленных элементов, длинной с полученное число.
            int[] array = new int[arrayLength];
            
            //3. С помощью цикла и обращаясь за значениями к пользователю заполните массив целочисленных элементов.
            int index = 0;

            while (index < arrayLength)
            {
                Console.Write($"Please give me {index + 1} number: ");
                array[index] = Convert.ToInt32(Console.ReadLine());
                index++;
            }

            //4. Отсортируйте массив по убыванию, после чего измените размер массива на +1 элемент.
            Array.Sort(array);
            Array.Reverse(array);

            int[] tempArray = new int[array.Length + 1];
            array.CopyTo(tempArray, 0);

            Console.WriteLine("The array was increased by 1.");

            //5. Обратитесь к пользователю и заполните новый элемент массива значением от пользователя.
            Console.Write("Please give me new number: ");
            tempArray[tempArray.Length - 1] = Convert.ToInt32(Console.ReadLine());
            array = tempArray;
            Console.Write($"The array now looks like this: ");
            int indexFin = 0;
            while (indexFin < array.Length)
            {
                Console.Write($"{array[indexFin]} ");
                indexFin++;
            }
        }
    }
}