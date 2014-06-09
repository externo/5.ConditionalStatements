using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberAsWords
{
    class Program
    {
        static int Hundred(int digit)
        {
            int 
            switch (digit)
            {
                case "0": textDigit = "zero"; break;
                case "1": textDigit = "one"; break;
                case "2": textDigit = "two"; break;
                case "3": textDigit = "three"; break;
                case "4": textDigit = "four"; break;
                case "5": textDigit = "five"; break;
                case "6": textDigit = "six"; break;
                case "7": textDigit = "seven"; break;
                case "8": textDigit = "eight"; break;
                case "9": textDigit = "nine"; break;
                default: textDigit = "not a digit"; break;
            }
        }
        static void Main()
        {
            Console.WriteLine(@"Program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.");
            Console.WriteLine("Write a number to convert: ");
            int number = Int16.Parse(Console.ReadLine());
            bool hundred = false;
            bool ten = false;
            string textNumber = "";
            if (number / 100 > 0)
            {
                hundred = true;
            }
            if (number / 10 > 0)
            {
                ten = true;
            }
        }
    }
}
