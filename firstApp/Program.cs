using System;

namespace Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.141593;
            const bool MY_CONST = true;
            string inputOne = Console.ReadLine();
            double numberOne = Convert.ToDouble(inputOne);
            bool iSConstBigger = PI > numberOne;
            bool lastOne = MY_CONST == iSConstBigger;
            Console.WriteLine($"{lastOne}");
        }
    }
}