using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayWithIntDoubleString
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Please choose a type:
1 --> int
2 --> double
3 --> string
");
            string choice = Console.ReadLine();
            string text;
            switch (choice)
            {
                case "1": text = "one"; break;
                case "2": text = "two"; break;
                case "3": text = "three"; break;
                default: text = "not a valid choice"; break;
            }

            Console.WriteLine("Please enter a {0}: ", text);
            string variable = Console.ReadLine();
            try
            {
                double number = double.Parse(variable);
                Console.WriteLine("The risult is {0}.", number + 1);
            }
            catch
            {
                Console.WriteLine("The risult is {0}.", variable + "*");
            }
        }
    }
}
