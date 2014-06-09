using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitAsWord
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).");
            Console.WriteLine("Enter a digit: ");
            string digit = Console.ReadLine();
            string textDigit = "";
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
            Console.WriteLine("The entered is {0}.", textDigit);
        }
    }
}
