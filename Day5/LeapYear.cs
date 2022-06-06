using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    internal class LeapYear
    {

        public void run()
        {
            Console.WriteLine("Enter the Year:");

            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine($"Enter year {year} is LEAP YEAR ");

            }
            else
            {
                Console.WriteLine($"Enter year {year} is NOT LEAP YEAR");
            }
            Console.ReadLine();


        }

    }
}
