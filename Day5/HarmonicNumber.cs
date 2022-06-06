using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    internal class HarmonicNumber
    {

        public void run()
        {
            Console.WriteLine("Enter the Mumber:");
            int number = Convert.ToInt32(Console.ReadLine());

            double value = 0;
            for (int i = 1; i <= number; i++)
            {
                value = value + (float)1 / i;
            }
            Console.WriteLine($"Harmonic number {value}");
        }

    }
}
