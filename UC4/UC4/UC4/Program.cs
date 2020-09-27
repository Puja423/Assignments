using System;
using System.Collections;

namespace UC4
{
    class Program
    {
        static void Main(string[] args)
        {
            var UseCase = Convert.ToInt32(Console.ReadLine());
            var Wage_Per_Hour = 20;
            var Full_Day_Hour = 8;
            switch (UseCase)
            {
                case 1:
                    Console.WriteLine(new Random().Next(0, 2) == 1 ? "Present" : "Absent");
                    break;

                case 2:
                    var Daily_Employee_Wage = Wage_Per_Hour * Full_Day_Hour;
                    Console.WriteLine("Daily Employee Wage is{0}", Daily_Employee_Wage);
                    break;

                case 3:
                    Console.Write("Enter Part Time Wage Per Hour : ");
                    var partTimeWagePerHour = Convert.ToInt32(Console.ReadLine());
                    var partTimeHour = 8;
                    var partTimeWage = partTimeWagePerHour * partTimeHour;
                    Console.WriteLine("Part Time Wage is {0}", partTimeWage);
                    break;


            }

        }
        }
    }
}
