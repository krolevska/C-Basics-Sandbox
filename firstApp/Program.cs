using System;

namespace SalaryCalc
{
    class Program
    {
        static void Input(out int quontityEmployee, out int salary)
        {
            Console.WriteLine("How many people work here? ");
            quontityEmployee = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much does 1 working day cost? ");
            int costPerDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many days did you work? ");
            int workingDays = Convert.ToInt32(Console.ReadLine());
            salary = costPerDay * workingDays;
        }

        static void Money(out int total, out int money)
        {
            Input(out int quontityEmployee, out int salary);
            money = salary;
            total = quontityEmployee * money;
        }

        static void Main(string[] args)
        {

            Money(out int moneyVolume, out int salary);
            Console.WriteLine($"The salary is {salary}");
            Console.WriteLine($"We need {moneyVolume} this month");

        }
    }
}