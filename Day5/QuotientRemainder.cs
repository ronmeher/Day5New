using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    internal class QuotientRemainder
    {

        public void run()
        {
            Console.WriteLine("Enter Divident");
            double divident = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter Divisor:");
            double divisor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The Quotient is {divident / divisor}");

            Console.WriteLine($"The Quotient is {divident % divisor}");



        }

    }
}
