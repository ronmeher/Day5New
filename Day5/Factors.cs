using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    internal class Factors
    {

        public void run()
        {

            Console.WriteLine("Enter the Number");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The prime Factors are 2");

            int isPrime;
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = 0;
                    for (int j = 2; j <= n / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = isPrime + 1;
                            break;
                        }
                        if (isPrime == 0)
                        {
                            Console.WriteLine($"The prime Factors are {i}");
                        }
                    }

                }

            }

        }

    }
}
