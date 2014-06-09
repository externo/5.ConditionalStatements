using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplicationSign
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Program that shows the sign (+, - or 0) of the product of three real numbers: a, b and c, 
without calculating it. Use a sequence of if operators. ");
            Console.WriteLine("Write a = ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Write b = ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Write c = ");
            float c = float.Parse(Console.ReadLine());
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("The product of {0}, {1} and {2} is 0.", a, b, c);
            }
            else if (a * b * c > 0)
            {
                Console.WriteLine("The sign of the product of {0}, {1} and {2} is +.", a, b, c);
            }
            else
            {
                Console.WriteLine("The sign of the product of {0}, {1} and {2} is -.", a, b, c);
            }
        }
    }
}
