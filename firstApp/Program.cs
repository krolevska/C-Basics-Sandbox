using System;

namespace SalaryCalc
{
    class Program
    {
        /// <summary>
        /// Создайте метод, который считает зарплату рабочему, 
        /// исходя из количества дней и подневной оплаты труда.
        /// 
        /// Пользователь вводит количество сотрудников предприятия,
        /// стоимость 1 трудодня сотрудника и количество дней, за которые производится оплата.
        /// </summary>
        /// <returns>quontityEmployee, salary</returns>
        static (int quontityEmployee, int salary) Input()
        {
            Console.WriteLine("How many people work here? ");
            int quontityEmployee = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much does 1 working day cost? ");
            int costPerDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many days did you work? ");
            int workingDays = Convert.ToInt32(Console.ReadLine());
            int salary = costPerDay * workingDays;

            return (quontityEmployee, salary);
        }
        /// <summary>
        /// Создайте метод, который принимает в себя количество сотрудников,
        /// количество рабочих дней и цену трудодня,
        /// и вычисляет общий объем денег, необходимый для оплаты полученному количеству сотрудников,
        /// используя внутри себя первый метод.
        /// 
        /// Посчитайте и выведите на экран общий объем денег,
        /// необходимый для оплаты зарплаты введенному пользователем количеству сотрудников.
        /// </summary>
        /// <returns>total</returns>
        static int Money()
        {
            var input = Input();
            int quontityEmployee = input.quontityEmployee, salary = input.salary;
            int total = quontityEmployee * salary;
            return total;
        }

        static void Main(string[] args)
        {

            var input = Input();
            int salary = input.salary;
            Console.WriteLine($"The salary is {salary}");

            int moneyVolume = Money();
            Console.WriteLine($"We need {moneyVolume} this month");

        }
    }
}