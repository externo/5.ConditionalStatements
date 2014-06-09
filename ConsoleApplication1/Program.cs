using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberAsWords
{
    public class NumberToString
    {
        static string[] ones = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        static string[] teens = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        static string[] tens = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        private static string Convert(int n, string leftDigits)
        {
            if (n == 0)
            {
                return leftDigits;
            }
            string stringNumber = leftDigits;
            if (stringNumber.Length > 0)
            {
                stringNumber += " ";
            }

            if (n < 10)
            {
                stringNumber += ones[n];
            }
            else if (n < 20)
            {
                stringNumber += teens[n - 10];
            }
            else if (n < 100)
            {
                stringNumber += Convert(n % 10, tens[n / 10 - 2]);
            }
            else
            {
                stringNumber += Convert(n % 100, (ones[n / 100] + " hundred and"));
            }
            return stringNumber;
        }

        public static string IntegerToWritten(int n)
        {
            if (n == 0)
            {
                return "Zero";
            }
            return Convert(n, "");
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that converts a number to words, corresponding to the English pronunciation.");
            Console.WriteLine("Write number to convert: ");
            int number = Int16.Parse(Console.ReadLine());
            Console.WriteLine("The number {0} in English pronunciation is {1}.", number, NumberToString.IntegerToWritten(number));
        }
    }
}
