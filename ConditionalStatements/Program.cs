using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExchangeIfGreater
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.");
            Console.WriteLine("Write a = ");
            string a = Console.ReadLine();
            Console.WriteLine("Write b = ");
            string b = Console.ReadLine();
            try
            {
                int a1 = Int16.Parse(a);
                int b1 = Int16.Parse(b);
                if (b1 < a1)
                {
                    Console.WriteLine("The risult is: {0} {1}", b, a);
                }
                else
                {
                    Console.WriteLine("The risult is: {0} {1}", a, b);
                }
            }
            catch 
            {
                Console.WriteLine("The risult is: {0} {1}", a, b);
            }
        }
    }
}
