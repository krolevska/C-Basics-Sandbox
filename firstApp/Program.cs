using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] monthNames = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int monthIndex = 0;
            int countAttempts = 0;
            int availableAttempts = 5;

            while (monthIndex < monthNames.Length)
            {
                // звернутися до користувача, щоб він ввів значення місяця по індексу
                Console.Write($"Please type the name of the month number {monthIndex + 1}: ");

                // користувач вводить значення місяця
                string monthName = Console.ReadLine();

                // перевіряємо, чи назва місяця співпадає
                bool monthIsCorect = monthName == monthNames[monthIndex];


                // якщо користувач пише правильно, наступна ітерація
                if (monthIsCorect)
                {
                    monthIndex++;
                    continue;
                }

                // якщо помиляється, повторюється та ж ітерація і росте лічильник спроб

                else
                {
                    // якщо менше 6 спроб
                    countAttempts++;
                    bool attemptsLeft = countAttempts < availableAttempts;
                    if (attemptsLeft)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }
    }
 }