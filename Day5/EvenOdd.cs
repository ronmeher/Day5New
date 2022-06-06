using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    internal class EvenOdd
    {

        public void run()
        {

            Console.WriteLine("Enter the Number:");
            int number = Convert.ToInt32(Console.ReadLine());


            if (number % 2 == 0)
            {
                Console.WriteLine($"Entered number {number} is Even number");
            }
            else
            {
                Console.WriteLine($"Entered number {number} is Odd number");
            }


        }

    }
}
