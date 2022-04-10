using System;

namespace Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            if (input > 3)
            {
                input += 10;     
            }
            else
            {
                input *= 10;
            }    
            Console.WriteLine(input);
        }
    }
}