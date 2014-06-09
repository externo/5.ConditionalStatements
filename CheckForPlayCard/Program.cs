using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckForPlayCard
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Classical play cards use the following signs to designate 
the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 

    Program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 
");
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            Console.WriteLine("Write valid card sign: ");
            string card = Console.ReadLine();
            if (cards.Contains(card))
            {
                Console.WriteLine("Yes! {0} is valid sign.", card);
            }
            else
            {
                Console.WriteLine("No! {0} is not valid sign.", card);
            }
        }
    }
}
