using System;

namespace UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Full_time = 1;
            int PART_TIME = 1;
            int EMP_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == Full_time)
            {
                empHrs = 8;
                Console.WriteLine(("fulltime wages:" + empHrs * EMP_PER_HOUR);
            }
            else if (empHrs <= 8)
            {
                Console.WriteLine("parttime wage:" + empHrs * EMP_PER_HOUR);
            }
            else
                empHrs = 0;
            Console.WriteLine("sorry you are not capable");
          
            

        }
    }
}
