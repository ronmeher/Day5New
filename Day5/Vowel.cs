using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    internal class Vowel
    {

        public void run()
        {
            Console.WriteLine("Enter an Alphabet!A");   
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
               
                case 'a':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
               
                case 'e':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
               
                case 'i':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
               
                case 'o':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                
                case 'u':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
               
                case 'A':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
               
                case 'E':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
               
                case 'I':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
               
                case 'O':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
               
                case 'U':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                
                default:
                    Console.WriteLine("The Alphabet is Consonant");
                    break;
            }


        }
    }
}
