using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiggestOf3Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Program that finds the biggest of three numbers a, b and c.");
            Console.WriteLine("Write a = ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Write b = ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Write c = ");
            float c = float.Parse(Console.ReadLine());
            float biggest = a;
            if (biggest < b)
            {
                biggest = b;
            }
            if (biggest < c)
            {
                biggest = c; 
            }
            Console.WriteLine("The biggest of the numbers {0}, {1} and {2} is {3}.", a, b, c, biggest);
        }
    }
}
