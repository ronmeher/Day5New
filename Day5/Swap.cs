using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    internal class Swap
    {

        public void run()
        {

            Console.WriteLine("Enter First Number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter First Number:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before swapping a : {a} b : {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"After swapping a : {a} b : {b}");
           
        }

    }
}
