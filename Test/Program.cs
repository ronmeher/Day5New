using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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
