using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiggestOfFiveNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that finds the biggest of five numbers a, b, c, d and e by using only five if statements.");
            Console.WriteLine("Write a = ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Write b = ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Write c = ");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("Write d = ");
            float d = float.Parse(Console.ReadLine());
            Console.WriteLine("Write e = ");
            float e = float.Parse(Console.ReadLine());
            float biggest = a;
            if (biggest < b)
            {
                biggest = b;
            }
            if (biggest < c)
            {
                biggest = c;
            }
            if (biggest < d)
            {
                biggest = d;
            }
            if (biggest < e)
            {
                biggest = e;
            }
            Console.WriteLine("The biggest of the numbers {0}, {1}, {2}, {3} and {4} is {5}.", a, b, c, d, e, biggest);
        }
    }
}
