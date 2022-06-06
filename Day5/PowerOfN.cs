using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    internal class PowerOfN
    {

        public void run()
        {
            Console.WriteLine("Enter the Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Power:");
            int pow = Convert.ToInt32(Console.ReadLine());

            int temp1 = num, temp2 = pow;
            int value = 1;
            while (pow != 0)
            {
                value = value * num;
                pow--;
            }
            Console.WriteLine($"The {temp1} power {temp2} is :  {value} ");


        }
    }
}
