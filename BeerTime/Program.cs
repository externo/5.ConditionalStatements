using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeerTime
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"program that enters a time in format “hh:mm tt” (an hour in range [01...12],
a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” according to the definition above
or “invalid time” if the time cannot be parsed.
");
            Console.WriteLine("Enter a time in format “hh:mm tt”: ");
            DateTime time = DateTime.Parse(Console.ReadLine());
            if (time.Hour<13 && time.Hour>=3)
            {
                Console.WriteLine("It's non-beer time.");
            }
            else
            {
                Console.WriteLine("It's beer time!");
            }
        }
    }
}
