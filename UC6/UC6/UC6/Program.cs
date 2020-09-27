using System;

namespace UC6
{
    class Program
    {
        static void Main(string[] args)
        {
            var Wage_Per_Hour = 20;
            var No_Of_Hour = 100;

            var Modified_monthly_Wage = Wage_Per_Hour * No_Of_Hour;
            Console.WriteLine("Modified Monthly Wage is {0}",Modified_monthly_Wage);
        }
    }
}
