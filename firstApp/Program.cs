using System;

namespace Methods
{
    class Program
    {
        static int One(int a, int b, int c)
        {
            return a + b + c;
        }
        static int Two (ref int a, ref int b, ref int c)
        {
            a++;
            b++;
            c++;
            return a + b + c;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()) , b = Convert.ToInt32(Console.ReadLine()), c = Convert.ToInt32(Console.ReadLine());
            bool method = Convert.ToBoolean(Console.ReadLine());
            int sum;
            if (method)
            {
                sum = One(a, b, c);
            }    
            else
            {
                sum = Two(ref a, ref b, ref c);
            }
            Console.WriteLine(sum);
        }

    }
}