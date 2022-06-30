using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
                    Console.Write("Give first number: ");
                    float  A = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Give second number: ");
                    float B = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Choose an arithmetic operation: +, -, * чи /? ");
                    string C = Console.ReadLine();
                    const string SUM = "+", MIN = "-", MULT = "*", DIV = "/";
                    float RESULT = 0;
                switch (C)
                {
                    case SUM:
                        {
                            RESULT = A + B;
                            Console.WriteLine(RESULT);
                            break;
                        }
                    case MIN:
                        {
                            RESULT = A - B;
                            Console.WriteLine(RESULT);
                            break;
                        }
                    case MULT:
                        {
                            RESULT = A * B;
                            Console.WriteLine(RESULT);
                            break;
                        }
                    case DIV:
                        {
                            if (B > 0)
                            {
                                RESULT = A / B;
                                Console.WriteLine(RESULT);
                            }
                            else
                            {
                                RESULT = 0;
                                Console.WriteLine("Cannot divide by zero. ");
                            }
                            break;
                        }
                    default:
                        {
                            RESULT = 0;
                            Console.WriteLine("Unknown operation, try again. ");
                            break;
                        }
                }
            }
        }
    }
 }