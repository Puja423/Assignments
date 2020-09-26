using System;

namespace UC3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Part Time Wage Per Hour : ");
            var partTimeWagePerHour = Convert.ToInt32(Console.ReadLine());
            var partTimeHour = 8;
            var partTimeWage = partTimeWagePerHour * partTimeHour;
            Console.WriteLine("Part Time Wage is {0}", partTimeWage);

        }
    }
}
