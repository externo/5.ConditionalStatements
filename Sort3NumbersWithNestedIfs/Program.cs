using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort3NumbersWithNestedIfs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that enters 3 real numbers a, b and c and prints them sorted in descending order.");
            Console.WriteLine("Write a = ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Write b = ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Write c = ");
            float c = float.Parse(Console.ReadLine());
            if (a < b)
            {
                if (b < c)
                {
                    Console.WriteLine("Numbers {0}, {1} and {2} in descending order are: {2}, {1}, {0}", a, b, c);
                }
                else
                {
                    if (a < c)
                    {
                        Console.WriteLine("Numbers {0}, {1} and {2} in descending order are: {1}, {2}, {0}", a, b, c); 
                    }
                    else
                    {
                        Console.WriteLine("Numbers {0}, {1} and {2} in descending order are: {1}, {0}, {2}", a, b, c);
                    }
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("Numbers {0}, {1} and {2} in descending order are: {0}, {1}, {2}", a, b, c);
                }
                else
                {
                    if (a > c)
                    {
                        Console.WriteLine("Numbers {0}, {1} and {2} in descending order are: {0}, {2}, {1}", a, b, c);
                    }
                    else
                    {
                        Console.WriteLine("Numbers {0}, {1} and {2} in descending order are: {2}, {0}, {1}", a, b, c);
                    }
                }
            }
        }
    }
}
