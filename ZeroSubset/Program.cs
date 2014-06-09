using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroSubset
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that finds all subsets of 5 given integer numbers x0, x1, x2, x3 and x4, whose sum is 0.");
            Console.WriteLine("Write x0 = ");
            int x0 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Write x1 = ");
            int x1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Write x2 = ");
            int x2 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Write x3 = ");
            int x3 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Write x4 = ");
            int x4 = Int16.Parse(Console.ReadLine());
            List<int> set= new List<int>{x0,x1,x2,x3,x4};
            bool zeroSubset = false;
            if (set.Sum() == 0)
            {
                zeroSubset = true;
                Console.WriteLine("Subset with sum 0 is ({0} {1} {2} {3} {4}).", x0, x1, x2, x3, x4);
            }
            foreach (int number in set)
            {
                if (number == 0)
                {
                    zeroSubset = true;
                    Console.WriteLine("Subset with sum 0 is ({0}).", number);
                }
                if (number == set.Sum())
                {
                    zeroSubset = true;
                    Console.Write("Subset with sum 0 is ");
                    foreach (int n in set)
                    {
                        if (n != number)
                        {
                            Console.Write(n+" ");
                        }
                    }
                    Console.Write(").");
                    Console.WriteLine();
                }
            }
            foreach (int number in set)
            {
                foreach (int otherNumber in set)
                {
                    if (number != otherNumber && otherNumber + number == 0)
                    {
                        zeroSubset = true;
                        Console.WriteLine("Subset with sum 0 is ({0} {1}).", otherNumber, number);
                    }
                    if (number != otherNumber && otherNumber + number == set.Sum())
                    {
                        zeroSubset = true;
                        Console.Write("Subset with sum 0 is (");
                        foreach (int n in set)
                        {
                            if (n != number && n != otherNumber)
                            {
                                Console.Write(n + " ");
                            }
                        }
                        Console.Write(").");
                        Console.WriteLine();
                    }
                }                
            }
            if (zeroSubset == false)
            {
                Console.WriteLine("No zero subset!");
            }
        }
    }
}