using System;

namespace UC5
{
    class Program
    {
        static void Main(string[] args)
        {
            var Wage_Per_Hour = 20;
            var Full_Day_Hour = 8;

            var Daily_employee_wage = Wage_Per_Hour * Full_Day_Hour;
            var Monthly_wage = Daily_employee_wage * Wage_Per_Hour;
            Console.WriteLine("Monthly_wage is{0}",Monthly_wage);
        }
    }
}
